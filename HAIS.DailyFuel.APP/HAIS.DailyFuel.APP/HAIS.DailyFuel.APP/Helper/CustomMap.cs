using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HAIS.DailyFuel.APP.Helper
{
    public class CustomMap : Map
    {
        public CustomMap(Position pos ) : base(MapSpan.FromCenterAndRadius(pos, Distance.FromMeters(300))) { }
        
    }
}
