using System;
using SQLite;

namespace pharm_dbb
{
    



	public class Texts
	{
		public Texts ()
		{
		}

	//	[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Description { get; set; }
        public int YesButton { get; set; }
        public int NoButton { get; set; }
        public int YesNext { get; set; }
        public int NoNext { get; set; }
        public int Back { get; set; }
    }
}

