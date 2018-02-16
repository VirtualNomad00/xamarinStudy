using System;
using Android.Content;
using Android.Locations;
using HAIS.DailyFuel.APP.Data;
using HAIS.DailyFuel.APP.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(GetMyLocation))]
namespace HAIS.DailyFuel.APP.Droid
{
    //---event arguments containing lat and lng---
    public class LocationEventArgs : EventArgs, ILocationEventArgs
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }

    public class GetMyLocation : Java.Lang.Object, IMyLocation, ILocationListener
    {
        LocationManager lm;

        public void OnProviderDisabled(string provider) { }

        public void OnProviderEnabled(string provider) { }

        public void OnStatusChanged(string provider, Availability status, Android.OS.Bundle extras) { }

        //---fired whenever there is a change in location---
        public void OnLocationChanged(Location location)
        {
            if (location != null)
            {
                LocationEventArgs args =
                            new LocationEventArgs
                            {
                                Lat = location.Latitude,
                                Long = location.Longitude
                            };
                LocationObtained(this, args);
            };

        }

        //---an EventHandler delegate that is called when
        // a location is obtained---
        public event EventHandler<ILocationEventArgs> LocationObtained;

        //---custom event accessor that is invoked when client
        // subscribes to the event---
        event EventHandler<ILocationEventArgs>IMyLocation.LocationObtained
        {
            add
            {
                LocationObtained += value;
            }
            remove
            {
                LocationObtained -= value;
            }
        }

        //---method to call to start getting location---
        public void ObtainMyLocation()
        {
            lm = (LocationManager)
                Android.App.Application.Context.GetSystemService(Context.LocationService);
            lm.RequestLocationUpdates(LocationManager.NetworkProvider, 0, 0, this);
        }

        //---stop the location update when the object is
        // set to null---
        ~GetMyLocation()
        {
            lm.RemoveUpdates(this);
        }
    }
}