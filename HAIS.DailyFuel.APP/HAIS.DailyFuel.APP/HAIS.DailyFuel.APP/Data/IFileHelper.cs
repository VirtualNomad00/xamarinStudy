using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Data
{
    interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
