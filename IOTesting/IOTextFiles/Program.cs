using System;

namespace IOTextFiles
{
	/// <summary>
	/// Главна програма
	/// </summary>

	class MainClass
	{
		//Дефиниции на статични методи
//		STable _STable = new STable (); //Декрарация на класа за таблицата
//		IOSettings _io = new IOSettings(_STable);

		public static void Main (string[] args)
		{
			STable _STable = new STable (); //Декрарация на класа за таблицата
			IOSettings _io = new IOSettings(_STable);



//			Console.WriteLine ( _STable.stable[0] );

			if ( _io.save() )
			{
				Console.WriteLine ( "Таблицата е запаметена." );
			}else{
				Console.WriteLine ( "Таблицата НЕ е запаметена." );
			}

		}
	}
}
