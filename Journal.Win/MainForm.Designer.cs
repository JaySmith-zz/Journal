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
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.ListView listViewRecentItems;
		private System.Windows.Forms.RichTextBox richTextBoxBody;
		private System.Windows.Forms.TextBox textBoxSubject;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelSubject;
		
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
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.listViewRecentItems = new System.Windows.Forms.ListView();
			this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelSubject = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// monthCalendar
			// 
			this.monthCalendar.Location = new System.Drawing.Point(13, 13);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 0;
			// 
			// listViewRecentItems
			// 
			this.listViewRecentItems.Location = new System.Drawing.Point(13, 188);
			this.listViewRecentItems.Name = "listViewRecentItems";
			this.listViewRecentItems.Size = new System.Drawing.Size(227, 316);
			this.listViewRecentItems.TabIndex = 1;
			this.listViewRecentItems.UseCompatibleStateImageBehavior = false;
			// 
			// richTextBoxBody
			// 
			this.richTextBoxBody.Location = new System.Drawing.Point(253, 63);
			this.richTextBoxBody.Name = "richTextBoxBody";
			this.richTextBoxBody.Size = new System.Drawing.Size(641, 407);
			this.richTextBoxBody.TabIndex = 2;
			this.richTextBoxBody.Text = "";
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Location = new System.Drawing.Point(311, 11);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(583, 20);
			this.textBoxSubject.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(805, 477);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// labelSubject
			// 
			this.labelSubject.Location = new System.Drawing.Point(253, 9);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(52, 23);
			this.labelSubject.TabIndex = 5;
			this.labelSubject.Text = "Subject";
			this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 516);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.richTextBoxBody);
			this.Controls.Add(this.listViewRecentItems);
			this.Controls.Add(this.monthCalendar);
			this.Name = "MainForm";
			this.Text = "Journal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
