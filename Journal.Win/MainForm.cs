using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Journal.Client;

namespace Journal.Windows
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		readonly DataService dataService;
		readonly List<JournalEntry> entries;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			dataService = new DataService();
			entries = dataService.ReadJournalEntries().OrderBy(x => x.CreateDate).ToList();
			
			InitializeCalendar();
		}
		
		void InitializeCalendar()
		{
			foreach (var entry in entries) 
			{
				Calendar.AddBoldedDate(entry.CreateDate);
			}
			
			LoadJournalEntryForSelectedDate(Calendar.SelectionStart);
		}
		
		void CalendarDateSelected(object sender, DateRangeEventArgs e)
		{
			LoadJournalEntryForSelectedDate(Calendar.SelectionStart);
		}
		
		void LoadJournalEntryForSelectedDate(DateTime selectedDate)
		{
			JournalEntry entry = entries.FirstOrDefault(x => x.CreateDate == selectedDate);
			
			if (entry != null)
			{
				textBoxSubject.Text = entry.Subject;
				richTextBoxBody.Text = entry.Body;
			}
			else 
			{
				textBoxSubject.Text = string.Empty;
				richTextBoxBody.Clear();
			}
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxSubject.Text)) return;
			if (string.IsNullOrEmpty(richTextBoxBody.Text)) return;
			
			Calendar.AddBoldedDate(Calendar.SelectionStart);
			Calendar.Refresh();
			
			var entry = new JournalEntry();
			entry.CreateDate = Calendar.SelectionStart;
			entry.Subject = textBoxSubject.Text;
			entry.Body = richTextBoxBody.Text;
			
			entries.Add(entry);
			
			dataService.SaveJournalEntries(entries);
			   
		}
	}
}
