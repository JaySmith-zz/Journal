/*
 * Created by SharpDevelop.
 * User: smithjay
 * Date: 1/12/2015
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Journal.Client
{
	/// <summary>
	/// Description of JournalEntry.
	/// </summary>
	public class JournalEntry
	{
		public JournalEntry()
		{
			CreateDate = DateTime.Now;
		}
		
		public int Id { get; set; }
		public JournalStatus Status { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime CreateDate { get; set; }
		
	}
}
