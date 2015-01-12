/*
 * Created by SharpDevelop.
 * User: smithjay
 * Date: 1/12/2015
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

using Journal.Client;

namespace Journal.Windows
{
	/// <summary>
	/// Description of JournalApplication.
	/// </summary>
	public class JournalApplication
	{
		readonly DataService dataService;
		
		public JournalApplication()
		{
			dataService = new DataService();
		}
		
		public List<JournalEntry> GetData()
		{
			return dataService.ReadJournalEntries();
		}
		
		public void SaveData(List<JournalEntry> entries)
		{
			dataService.SaveJournalEntries(entries);
		}
		
		void TestWrite()
		{
			var entries = new List<JournalEntry>();
			
			for (int i = 0; i < 10; i++) {
				var entry = new JournalEntry();
				
				entry.Id = 1;
				entry.CreateDate = DateTime.Now;
				entry.Subject = "Subject " + i;
				entry.Body = "Body of entry " + i;
				
				entries.Add(entry);
			}
			
			SaveData(entries);
			
		}
		
		void TestRead()
		{
			var entries = GetData();
			
			var count = entries.Count;
		}
		
		public void Test()
		{
			TestWrite();
			TestRead();
		}
	}
}
