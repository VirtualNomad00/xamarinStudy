using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Geolocator;
using System.Threading.Tasks;

namespace HAIS.DailyFuel.APP.Models
{
    class Location
    {
        public double Lat { get; set; }
        public double Long { get; set; }

        //public async Task GetCurrentLocationAsync()
        //{
        //    var geolocator = CrossGeolocator.Current;
        //    geolocator.DesiredAccuracy = 50;
        //    if (geolocator.IsGeolocationEnabled && CrossGeolocator.IsSupported && geolocator.IsGeolocationAvailable)
        //    {
        //        try
        //        {
        //            if (!geolocator.IsListening)
        //                await geolocator.StartListeningAsync(TimeSpan.FromMilliseconds(10), 100, true);

        //            var position = await geolocator.GetPositionAsync(TimeSpan.FromSeconds(10), null , true);
                    
        //            System.Diagnostics.Debug.WriteLine("[GetPosition] Lat. : {0} / Long. : {1}", position.Latitude.ToString("N4"), position.Longitude.ToString("N4"));

        //            this.CurrentLatitude = position.Latitude;
        //            this.CurrentLongitude = position.Longitude;
        //        }
        //        catch (Exception e)
        //        {
        //            System.Diagnostics.Debug.WriteLine("Error : {0}", e);
        //        }
               
        //    }
        //}

    }
}
