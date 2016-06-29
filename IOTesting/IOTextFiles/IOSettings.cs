using System;

namespace IOTextFiles
{
	/// <summary>
	/// Клас за IO settings.
	/// </summary>


	public class IOSettings
	{
		private STable _stable; //Дефиниция на вътрешна променлива клас

		/// <summary>
		/// Конструктор на клас IOTextFiles. Инициализация на класа
		/// </summary>
		/// <param name="stable">Масив на таблицата.</param>
		public IOSettings ( STable stable )
		{
			_stable = stable;
		}

		public string getpath()
		{

			//Други директории
			//string _user = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			string _user = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string _desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
			Console.WriteLine(_user);
			Console.WriteLine(_desktop);


			string _path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.txt");
			return _path;
		}



		/// <summary>
		/// Save text file.
		/// </summary>
		public bool save()
		{
			try
			{
				string _temp ="" ;
				_temp = String.Join("\r\n",_stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText (getpath(),_temp);

				return true;
			}catch{
			}

			return false;

		}


		public bool open()
		{
			try
			{
				string 	_temp = System.IO.File.ReadAllText (getpath());
				string[] _table=_temp.Replace("\r","").Split('\n');

				for (int i=0;i<_table.Length;i++)
				{
					_stable.stable[i]=_table[i];
				}

				return true;
			}catch{
			}

			return false;

		}



	}
}

