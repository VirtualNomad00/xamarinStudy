using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using HAIS.DailyFuel.APP.controls;
using HAIS.DailyFuel.APP.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly : ExportRenderer(typeof(CustomCornerLabel), typeof(CustomCornerLabelRenderer))]
namespace HAIS.DailyFuel.APP.iOS
{
    class CustomCornerLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null){
                var _xfViewRrefrence = (CustomCornerLabel)Element;

                this.Layer.CornerRadius = (float)_xfViewRrefrence.CurvedCornerRadius;
                this.Layer.BackgroundColor = _xfViewRrefrence.CurvedBackgroundColor.ToCGColor();
            }
        }
    }
}