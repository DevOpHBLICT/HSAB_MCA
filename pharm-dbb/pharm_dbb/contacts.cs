using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DoLS
{
    public class contacts : ContentPage
    {
        public contacts()
        {

           var tel= new Label { TextColor = Color.FromHex("a8288e") , Text = "01438 843800" };
            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => {
                Device.OpenUri(new Uri("tel://01438843800"));
            };
            tel.GestureRecognizers.Add(tgr);


            var em = new Label { Text = "dolsteam@hertfordshire.gov.uk" };
            var t = new TapGestureRecognizer();
            t.Tapped += (s, e) => {
                Device.OpenUri(new Uri("dolsteam@hertfordshire.gov.uk"));
            };
            em.GestureRecognizers.Add(t);
            Content = new StackLayout
            {
                Children = {
                new Label { FontAttributes= FontAttributes.Bold,Text = "Contacts" },
                new Label { Text = "Hertfordshire DoLs team" },
                tel,
                em,
             
                new Label { Text = "Deprivation of Liberty Safeguards Team" },
                new Label { Text = "Hertfordshire Supervisory Body" },
                new Label { Text = "SFAR 016 Farnham House" },
                new Label { Text = "Six Hills Way" },
                new Label { Text = "Stevenage SG1 2FQ" },
                }
            };
        }
    }
}
