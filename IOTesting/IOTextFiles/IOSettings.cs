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
		public IOSettings(STable stable)
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

			//Програма/Settings/Settings.txt
			//string _path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
			string _path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings");
			_path = System.IO.Path.Combine(_path, "Settings.txt");
			return _path;
		}



		/// <summary>
		/// Save text file.
		/// </summary>
		public bool save()
		{
			try
			{
				string _temp = "";
				_temp = String.Join("\r\n", _stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText(getpath(), _temp);

				return true;
			}
			catch
			{
			}

			return false;

		}


		//public bool open()
		//{
		//	try
		//	{
		//		string 	_temp = System.IO.File.ReadAllText (getpath());
		//		string[] _table=_temp.Replace("\r","").Split('\n');

		//		for (int i=0;i<_table.Length;i++)
		//		{
		//			_stable.stable[i]=_table[i];
		//		}

		//		return true;
		//	}catch{
		//	}

		//	return false;

		//}


		public bool open()
		{
			try
			{
				iniSettings();
				string _temp = "", _filepath = getpath();
				Console.WriteLine(_filepath);

				if (System.IO.File.Exists(_filepath))          //Проверка дали пътят е валиден
				{
					_temp = System.IO.File.ReadAllText(_filepath);
					string[] _table = _temp.Replace("\r", "").Split('\n');

					for (int i = 0; i < _table.Length; i++)
					{
						_stable.stable[i] = _table[i];
					}
					System.Diagnostics.Process.Start(_filepath);

					return true;

				}
				else {
					Console.WriteLine("Не е намерен такъв път");
					return false;
				}

			}
			catch
			{
			}

			return false;

		}



		private void iniSettings()
		{

			try
			{
				bool _fileExist = System.IO.File.Exists( getpath());
				if (!_fileExist)
				{
					string _directory = System.IO.Path.GetDirectoryName(  getpath());

					//Застраховаме се ,че директорията съществува
					if ( !System.IO.Directory.Exists (_directory) )
					{
						System.IO.Directory.CreateDirectory(_directory);

					}
					//Запаметяваме съдържанието на файла
					save();
				}
			}
			catch
			{
			}

		}




	}
}

