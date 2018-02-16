using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using HAIS.DailyFuel.APP.controls;
using HAIS.DailyFuel.APP.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace HAIS.DailyFuel.APP.Droid
{
    public class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        CustomPicker element;
        Typeface fontFace = null;
        private IElementController ElementController => Element as IElementController;
        private AlertDialog _dialog;


        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null || e.OldElement != null || Control == null)
                return;

            fontFace = Typeface.CreateFromAsset(this.Context.Assets, "Avenir Next Demi Bold.otf");
            element = (CustomPicker)this.Element;
            if (Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image))
            {
                Control.Background = AddPickerStyle(element.Image);
            }


            Control.TextSize = 20f;
            Control.SetTypeface(fontFace, TypefaceStyle.Normal);

            Control.Click += Control_Click;
        }
        protected override void Dispose(bool disposing)
        {
            Control.Click -= Control_Click;
            base.Dispose(disposing);
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Picker model = Element;
            NumberPicker picker = new NumberPicker(Context);

            int count = picker.ChildCount;
            for (int i = 0; i < count; i++)
            {
                Android.Views.View v = picker.GetChildAt(i);
                if (v.GetType() == typeof(EditText))
                {
                    Java.Lang.Reflect.Field field = picker.Class.GetDeclaredField("mSelectorWheelPaint");
                    field.Accessible = true;
                    ((Paint)field.Get(picker)).SetTypeface(fontFace);
                    ((EditText)v).SetTypeface(fontFace, TypefaceStyle.Normal);
                    picker.Invalidate();
                }
            }

            if (model.Items != null && model.Items.Any())
            {
                picker.MaxValue = model.Items.Count - 1;
                picker.MinValue = 0;
                picker.SetDisplayedValues(model.Items.ToArray());
                picker.WrapSelectorWheel = false;
                picker.DescendantFocusability = DescendantFocusability.BlockDescendants;
                picker.Value = model.SelectedIndex;
                picker.Visibility = ViewStates.Visible;

            }


            var layout = new LinearLayout(Context) { Orientation = Orientation.Vertical };
            layout.Visibility = ViewStates.Visible;
            layout.AddView(picker);


            ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, true);

            var builder = new AlertDialog.Builder(Context);
            builder.SetView(layout);

            builder.SetTitle(model.Title ?? "");

            builder.SetNegativeButton("Cancel", (s, a) =>
            {
                ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                Control?.ClearFocus();
                _dialog = null;
            });

            builder.SetPositiveButton("This One", (s, a) =>
            {
                ElementController.SetValueFromRenderer(Picker.SelectedIndexProperty, picker.Value);
                if (Element != null)
                {
                    if (model.Items.Count > 0 && Element.SelectedIndex >= 0)
                        Control.Text = model.Items[Element.SelectedIndex];
                    ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                    Control?.ClearFocus();
                }
                _dialog = null;
            });

            _dialog = builder.Create();

            _dialog.DismissEvent += (ssender, args) =>
            {
                ElementController?.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
            };
            _dialog.Show();

            Android.Widget.Button nbutton = _dialog.GetButton((int)Android.Content.DialogButtonType.Positive);
            nbutton.SetTypeface(fontFace, TypefaceStyle.Normal);
            nbutton.SetTextColor(Android.Graphics.Color.ParseColor("#666ad1"));
            nbutton.TextSize = 18f;
            LinearLayout layOut = (LinearLayout)nbutton.Parent;
            layOut.SetGravity(GravityFlags.CenterHorizontal);
            Android.Views.View v1 = layOut.GetChildAt(1);
            v1.Visibility = ViewStates.Gone;

            Android.Widget.Button cButton = _dialog.GetButton((int)Android.Content.DialogButtonType.Negative);
            cButton.SetTypeface(fontFace, TypefaceStyle.Normal);
            cButton.TextSize = 18f;
            LinearLayout clayOut = (LinearLayout)cButton.Parent;
            clayOut.SetGravity(GravityFlags.CenterHorizontal);
            Android.Views.View v2 = clayOut.GetChildAt(1);
            v2.Visibility = ViewStates.Gone;

            int res = Resources.GetIdentifier("alertTitle", "id", "android");
            TextView textView = (TextView)_dialog.FindViewById(res);
            textView.SetTextColor(Android.Graphics.Color.Black);
            textView.SetTypeface(fontFace, TypefaceStyle.Normal);
            textView.SetTextSize(Android.Util.ComplexUnitType.Px, 100f);
            textView.Gravity = GravityFlags.Center;

        }

        public LayerDrawable AddPickerStyle(string imagePath)
        {
            //ShapeDrawable border = new ShapeDrawable();
            //border.Paint.Color = Android.Graphics.Color.Gray;
            //border.SetPadding(20, 10, 10, 10);
            //border.Paint.SetStyle(Paint.Style.Stroke);

            GradientDrawable _gradientDrawable = new GradientDrawable();
            _gradientDrawable.SetStroke(0, Android.Graphics.Color.Transparent);
            Drawable[] layers = { _gradientDrawable, GetDrawable(imagePath) };
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            layerDrawable.SetLayerInset(0, 0, 0, 0, 0);
            return layerDrawable;
        }

        private Drawable GetDrawable(string imagePath)
        {
            int resID = Resources.GetIdentifier(imagePath, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 70, 70, true))
            {
                Gravity = Android.Views.GravityFlags.Right
            };
            return result;
        }

    }
}

