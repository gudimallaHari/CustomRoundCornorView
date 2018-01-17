using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRoundCornorView.CustomView;
using CustomRoundCornorView.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRendererAttribute(typeof(BorderView), typeof(BorderViewRenderer))]
namespace CustomRoundCornorView.Droid.CustomRenderers
{
    public class BorderViewRenderer : VisualElementRenderer<BorderView>
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            //HandlePropertyChanged (sender, e);
            BorderRendererVisual.UpdateBackground(Element, this.ViewGroup);
        }


        protected override void OnElementChanged(ElementChangedEventArgs<BorderView> e)
        {
            base.OnElementChanged(e);
            BorderRendererVisual.UpdateBackground(Element, this.ViewGroup);
        }

        /*void HandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Content")
			{
				BorderRendererVisual.UpdateBackground (Element, this.ViewGroup);
			}
		}*/

        protected override void DispatchDraw(Android.Graphics.Canvas canvas)
        {
            if (Element.IsClippedToBorder)
            {
                canvas.Save(SaveFlags.Clip);
                BorderRendererVisual.SetClipPath(this, canvas);
                base.DispatchDraw(canvas);
                canvas.Restore();
            }
            else
            {
                base.DispatchDraw(canvas);
            }
        }

    }
}