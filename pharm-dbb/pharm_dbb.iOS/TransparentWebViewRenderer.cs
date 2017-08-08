using pharm_dbb;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(TransparentWebView), typeof(TransparentWebViewRenderer))]

    public class TransparentWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
   
        base.OnElementChanged(e);

        this.Opaque = false;
        this.BackgroundColor = Color.Transparent.ToUIColor();
    }

}
  
