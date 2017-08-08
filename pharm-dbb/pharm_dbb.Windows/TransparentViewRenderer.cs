using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharm_dbb;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;
using pharm_dbb.Windows;

[assembly: ExportRenderer(typeof(TransparentWebView), typeof(TransparentWebViewRenderer))]

  namespace pharm_dbb.Windows
{
    public class TransparentWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
          //  this.Control.DefaultBackgroundColor = Windows.UI.Colors.Transparent;
        }
    }
}