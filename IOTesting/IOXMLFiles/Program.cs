using System;
using System.Xml;
using System.Xml.Linq;


namespace IOXMLFiles
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			//запис
			//string value = "simple value", property = "simple property";
			//string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			//using (XmlWriter writer = XmlWriter.Create(path))
			//{
			//	writer.WriteStartDocument();
			//	writer.WriteStartElement("settings");

			//	//съдържание на файла
			//	writer.WriteStartElement("row");


			//	writer.WriteAttributeString("property", property);   //<row property=...> ...
			//	writer.WriteString(value);     //<row> value </row>

			//	writer.WriteEndElement();	


			//	writer.WriteEndElement();
			//	writer.WriteEndDocument();
			//}

			//XDocument document = XDocument.Load(path);
			//document.Save(path);



			//четене
			string value = "", property = "";
			string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			using (XmlReader reader = XmlReader.Create(path))
			{

				while (reader.Read())
				{
					switch(reader.Name)
					{

						case "row":
							property = reader["property"];
							value = reader.ReadInnerXml();

							Console.WriteLine("value = " + value);
							Console.WriteLine("property = " + property);
							break;

						case "simplerow":
							
							value = reader.ReadInnerXml();

							Console.WriteLine("value = " + value);



							break;
					}




				}

			}

			Console.ReadKey();



		}
	}
}
