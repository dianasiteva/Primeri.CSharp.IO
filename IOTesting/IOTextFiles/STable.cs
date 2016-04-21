using System;

namespace IOTextFiles
{
	/// <summary>
	/// STable - клас за справочната таблица
	/// </summary>

	public class STable
	{
		public string[] stable = new string[4];   //променлива масив за таблицата

		public STable ()
		{
			fillSTable ();
		}

		/// <summary>
		/// Вътрешен метод за попълване на масива за таблицата
		/// </summary>

		private void fillSTable()
		{
			stable[0] = "1,0,5,0.4896";
			stable[1] = "2,5,10,0.5896";
			stable[2] = "3,10,15,0.6896";
			stable[3] = "4,15,20,0.7896";
		}


	}
}

