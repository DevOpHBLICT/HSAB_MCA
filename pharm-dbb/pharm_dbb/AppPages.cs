using System;
using SQLite;

namespace pharm_dbb
{
	public class AppPages
	{
		public AppPages ()
		{
		}

        //	[PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}

