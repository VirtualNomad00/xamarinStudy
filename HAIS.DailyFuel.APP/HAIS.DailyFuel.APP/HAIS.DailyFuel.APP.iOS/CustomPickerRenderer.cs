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

[assembly : ExportRenderer( typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace HAIS.DailyFuel.APP.iOS
{
    class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            var element = (CustomPicker)this.Element;

            if(this.Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image))
            {
                var downArrow = UIImage.FromBundle(element.Image);
                Control.RightViewMode = UITextFieldViewMode.Always;
                Control.RightView = new UIImageView(downArrow);
            }
        }
    }
}