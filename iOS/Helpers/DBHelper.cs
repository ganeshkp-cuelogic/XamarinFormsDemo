using System;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinFormsDemo.iOS.DBHelper))]
namespace XamarinFormsDemo.iOS
{	
	public class DBHelper: IDataBase
	{
		public DBHelper()
		{
			
		}

		public string getDataBasePath()
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = System.IO.Path.Combine(docFolder, "..", "Library", "Databases");

			if (!System.IO.Directory.Exists(libFolder))
			{
				System.IO.Directory.CreateDirectory(libFolder);
			}

			return System.IO.Path.Combine(libFolder, "XamarinFormsDBiOS");
		}
	}
}
