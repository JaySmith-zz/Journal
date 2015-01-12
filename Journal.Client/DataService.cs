/*
 * Created by SharpDevelop.
 * User: smithjay
 * Date: 1/12/2015
 * Time: 8:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

using Polenter.Serialization;

namespace Journal.Client
{
	/// <summary>
	/// Description of DataService.
	/// </summary>
	public class DataService
	{
		SharpSerializer serializer;
			
		public DataService()
		{
			serializer = new SharpSerializer();
		}
		
		public List<JournalEntry> ReadJournalEntries()
		{
			return serializer.Deserialize("journal.xml") as List<JournalEntry>;
		}
		
		public void SaveJournalEntries(IEnumerable<JournalEntry> entries)
		{
			serializer.Serialize(entries, "journal.xml");
		}
		                          
	}
}
