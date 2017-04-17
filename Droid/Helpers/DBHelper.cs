using System;
using System.IO;
using XamarinFormsDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DBHelper))]
namespace XamarinFormsDemo.Droid
{
	public class DBHelper: IDataBase
	{
		public DBHelper()
		{
			
		}
		public string getDataBasePath()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "XamarinFormsDBAndroid");
		}
	}
}
