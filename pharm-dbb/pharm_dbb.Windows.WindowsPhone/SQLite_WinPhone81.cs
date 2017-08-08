
using System;
using System.IO;
using pharm_dbb;
using pharm_dbb.UWP;
using Xamarin.Forms;
using Windows.Storage;
using pharm_dbb.Windows;

[assembly: Dependency (typeof (SQLite_WinPhone81))] 
 
 
 namespace pharm_dbb.Windows
 { 
 	public class SQLite_WinPhone81 : ISQLite 
	{ 
 		public SQLite_WinPhone81()
 		{ 
 		} 
 		#region ISQLite implementation 
 		public SQLite.SQLiteConnection GetConnection()
 		{ 
 			var sqliteFilename = "db2.db"; 
             string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename); 
 
 
             var conn = new SQLite.SQLiteConnection(path); 
 
 
			// Return the database connection  
 			return conn; 
 		} 
 		#endregion 
 	} 
 } 
