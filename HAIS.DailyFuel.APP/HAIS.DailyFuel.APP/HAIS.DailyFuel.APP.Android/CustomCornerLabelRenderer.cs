using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using HAIS.DailyFuel.APP.controls;
using HAIS.DailyFuel.APP.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly : ExportRenderer( typeof(CustomCornerLabel), typeof(CustomCornerLabelRenderer))]
namespace HAIS.DailyFuel.APP.Droid
{
    class CustomCornerLabelRenderer : LabelRenderer
    {
        private GradientDrawable _gradientDrawable;
        public CustomCornerLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (CustomCornerLabel)Element;
            if (view == null) return;

            _gradientDrawable = new GradientDrawable();
            _gradientDrawable.SetShape(ShapeType.Rectangle);

            _gradientDrawable.SetColor(view.CurvedBackgroundColor.ToAndroid());
            _gradientDrawable.SetStroke(4, view.CurvedBackgroundColor.ToAndroid());
            _gradientDrawable.SetCornerRadius(
                DpToPixels(this.Context,Convert.ToSingle(view.CurvedCornerRadius)));

            Control.SetBackground(_gradientDrawable);
        }

        public static float DpToPixels(Context context, float ValueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, ValueInDp, metrics);
        }

    }
}