/*
 * Created by SharpDevelop.
 * User: smithjay
 * Date: 1/12/2015
 * Time: 8:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Journal.Windows
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MonthCalendar Calendar;
		private System.Windows.Forms.RichTextBox richTextBoxBody;
		private System.Windows.Forms.TextBox textBoxSubject;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelSubject;
		private System.Windows.Forms.SplitContainer splitContainer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Calendar = new System.Windows.Forms.MonthCalendar();
			this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelSubject = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Calendar
			// 
			this.Calendar.Location = new System.Drawing.Point(9, 9);
			this.Calendar.MaxSelectionCount = 1;
			this.Calendar.Name = "Calendar";
			this.Calendar.TabIndex = 0;
			this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDateSelected);
			// 
			// richTextBoxBody
			// 
			this.richTextBoxBody.Location = new System.Drawing.Point(10, 42);
			this.richTextBoxBody.Name = "richTextBoxBody";
			this.richTextBoxBody.Size = new System.Drawing.Size(624, 404);
			this.richTextBoxBody.TabIndex = 2;
			this.richTextBoxBody.Text = "";
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Location = new System.Drawing.Point(63, 16);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(571, 20);
			this.textBoxSubject.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(559, 466);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// labelSubject
			// 
			this.labelSubject.Location = new System.Drawing.Point(5, 14);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(52, 23);
			this.labelSubject.TabIndex = 5;
			this.labelSubject.Text = "Subject";
			this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Calendar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxSubject);
			this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
			this.splitContainer1.Panel2.Controls.Add(this.labelSubject);
			this.splitContainer1.Panel2.Controls.Add(this.richTextBoxBody);
			this.splitContainer1.Size = new System.Drawing.Size(906, 516);
			this.splitContainer1.SplitterDistance = 248;
			this.splitContainer1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 516);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "Journal";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
