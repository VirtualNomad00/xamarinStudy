using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Data
{
    public interface IMyLocation
    {
        void ObtainMyLocation();
        event EventHandler<ILocationEventArgs> LocationObtained;
    }

    public interface ILocationEventArgs
    {
        double Lat { get; set; }
        double Long { get; set; }
    }
}
