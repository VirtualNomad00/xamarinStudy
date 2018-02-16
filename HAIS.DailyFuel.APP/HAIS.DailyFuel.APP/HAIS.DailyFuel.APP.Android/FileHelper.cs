using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HAIS.DailyFuel.APP.Data;
using HAIS.DailyFuel.APP.Droid;
using Xamarin.Forms;

[assembly : Dependency(typeof(FileHelper))] 
namespace HAIS.DailyFuel.APP.Droid
{
    class FileHelper : IFileHelper
    {
        public string GetLocalFilePath( string fileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}