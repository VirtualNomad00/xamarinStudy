using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreLocation;
using Foundation;
using HAIS.DailyFuel.APP.Data;
using HAIS.DailyFuel.APP.iOS;
using Plugin.Geolocator.Abstractions;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetMyLocation))]
namespace HAIS.DailyFuel.APP.iOS
{
    //---event arguments containing lat and lng---
    public class LocationEventArgs : EventArgs, ILocationEventArgs
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }

    public class GetMyLocation : IMyLocation
    {
        CLLocationManager lm;

        //---an EventHandler delegate that is called when a
        // location is obtained---
        public event EventHandler<ILocationEventArgs> LocationObtained;

        //---custom event accessor when client subscribes
        // to the event---
        event EventHandler<ILocationEventArgs> IMyLocation.LocationObtained
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
            lm = new CLLocationManager
            {
                DesiredAccuracy = CLLocation.AccuracyBest,
                DistanceFilter = CLLocationDistance.FilterNone
            };

            //---fired whenever there is a change in location---
            lm.LocationsUpdated += (object sender, CLLocationsUpdatedEventArgs e) =>
            {
                var locations = e.Locations;
                var strLocation =
                    locations[locations.Length - 1].
                        Coordinate.Latitude.ToString();
                strLocation = strLocation + "," +
                    locations[locations.Length - 1].
                        Coordinate.Longitude.ToString();

                LocationEventArgs args = new LocationEventArgs
                {
                    Lat = locations[locations.Length - 1].
                    Coordinate.Latitude,
                    Long = locations[locations.Length - 1].
                    Coordinate.Longitude
                };
                LocationObtained(this, args);
            };

            lm.AuthorizationChanged += (object sender, CLAuthorizationChangedEventArgs e) =>
            {
                if (e.Status == CLAuthorizationStatus.AuthorizedWhenInUse)
                {
                    lm.StartUpdatingLocation();
                }
            };

            lm.RequestWhenInUseAuthorization();
        }

        //---stop the location update when the object is set to
        // null---
        ~GetMyLocation()
        {
            lm.StopUpdatingLocation();
        }
    }
}