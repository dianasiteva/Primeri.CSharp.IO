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
				System.IO.File.WriteAllText ("C:\\aula\\test.txt",_temp);

				return true;
			}catch{
			}

			return false;

		}


	}
}

