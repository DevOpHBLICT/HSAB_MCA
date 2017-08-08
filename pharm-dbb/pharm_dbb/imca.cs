using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{



    public class imca : CarouselPage
    {
      
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        


        void BackButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }

        public imca(String info)
        {
            BackgroundColor = Color.White;
            Button home = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "home", TextColor = Color.Black };
            Button back = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Image = "back" };
            Button next = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "next", TextColor = Color.Black };
            back.Image = (FileImageSource)ImageSource.FromFile("back.png");
            back.HorizontalOptions = LayoutOptions.End;
            back.VerticalOptions = LayoutOptions.End;
            back.BackgroundColor = Color.Transparent;
           
            back.Clicked += BackButtonClicked;
            Title = info;
            // Label title = null;
            if (Device.OS == TargetPlatform.Windows)
            {
                BackgroundColor = Color.White;
                NavigationPage.SetHasNavigationBar(this, false);
                //   this.TranslationY = -40;
            }

            Label title = new Label
            {
                Text = info,
                XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)

            };
            title.TextColor = Color.FromHex("#953735");

            Label title2 = new Label
            {
                Text = "Additional information",
                XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(18)

            };
            title2.TextColor = Color.FromHex("#953735");
            Label l1 = new Label
            {
                InputTransparent = true,
                XAlign = TextAlignment.Start,
                Font = Font.SystemFontOfSize(16)

            };
            l1.TextColor = Color.Black;
            l1.IsEnabled = true;

            Label l2 = new Label
            {
                InputTransparent = true,
                XAlign = TextAlignment.Start,
                Font = Font.SystemFontOfSize(16)

            };
            l2.TextColor = Color.Black;
            l2.IsEnabled = true;

            Label l3 = new Label
            {
                InputTransparent = true,
                XAlign = TextAlignment.Start,
                Font = Font.SystemFontOfSize(16)

            };
            l3.TextColor = Color.Black;
            l3.IsEnabled = true;

            Label l4 = new Label
            {
                InputTransparent = true,
                XAlign = TextAlignment.Start,
                Font = Font.SystemFontOfSize(16)

            };
            l4.TextColor = Color.Black;
            l4.IsEnabled = true;
            Label l5 = new Label
            {
                InputTransparent = true,
                XAlign = TextAlignment.Start,
                Font = Font.SystemFontOfSize(16)

            };
            l5.TextColor = Color.Black;
            l5.IsEnabled = true;

                  a =  "An Independent Mental Capacity Advocate (IMCA) must be instructed when the person is found to lack capacity and a best interest decision is needed and the person has no appropriate person (friends or family) to consult on the following decisions:< ul >< li > Serious medical treatment</ li > < li > A change of accommodation </ li ></ ul > ";
                 b= "In addition, there is a duty in the NHS and social care settings to consider requesting an IMCA in the following circumstances:<ul >< li > Safeguarding Adults from Abuse </ li > < li > Care Reviews </ li ></ ul > ";
                 c = "The IMCA’s role in these circumstances is to:< ul >< li > Gather  the views and beliefs of person</ li >< li > Evaluate all the relevant information</ li >< li > Provide a written report to assist the decision maker (e.g.Doctor) </ li ></ ul > ";
                d= "If you need to instruct an IMCA please contact the Hertfordshire service (POhWER) via:< p > Email - pohwer@pohwer.net <p> Webpage - < a href = 'http://www.pohwer.net/index-13.html' > (POhWER) </ a > < p> Phone - 0300 456 2370";
          
                l1.Text = a;
                l2.Text = b;
                l3.Text = c;
                l4.Text = d;
            

    

        


            var S = new StackLayout
            {
                Spacing = 5,
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Children =
                        {

                         
                            home,
                                new Image
                  {
                      VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                      Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                      Source = ImageSource.FromFile("swipe.png")
                  },
                        }
            };


            

            var first_page = new ContentPage
            {
               


                Content = new StackLayout()
                {

                    ///   BackgroundColor = Color.White,
                    //  InputTransparent = true,
                    Padding = new Thickness(20, 20, 20, 20),
                    //    Children = { title,l,t,S}
                    //      Children = { title, title2, l1}
                    Children = {
                        new Label { Text = info,
                        TextColor = Color.FromHex("#953735"),
            XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)},
                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(18)
                 },
                 l1,
           

             


                },
                    

                 


                }

            };

            var second_page = new ContentPage
            {
      
                Content = new StackLayout {
                    Padding = new Thickness(20, 20, 20, 20),
                    Children = {
                 new Label { Text = info,
                        TextColor = Color.FromHex("#953735"),
            XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)},
                new Label
                 {
                  Text = "IMCA",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(18)
                 },
                    l2 ,
                   
                    }
                }
            };
            var third_page = new ContentPage
            {
                Padding = new Thickness(5, 5, 5, 5),
                Content = new StackLayout {
                    Padding = new Thickness(20, 20, 20, 20),
                    Children = {
                    new Label { Text = info,
                        TextColor = Color.FromHex("#953735"),
            XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)},
                new Label
                 {
                  Text = "IMCA",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(18)
                 },
                    l3,
                   

                    }
                }
            };
            var forth_page = new ContentPage
            {
               
                Content = new StackLayout {
                    Padding = new Thickness(20, 20, 20, 20),
                    Children = {
                   new Label { Text = info,
                        TextColor = Color.FromHex("#953735"),
            XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)},
                new Label
                 {
                  Text = "IMCA",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(18)
                 },
                    l4,
                   

                    }
                }
            };

            var fifth_page = new ContentPage
            {
                Padding = new Thickness(5, 5, 5, 5),
                Content = new StackLayout
                {
                    Children = {
                   new Label { Text = info,
                        TextColor = Color.FromHex("#953735"),
            XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(25)},
                new Label
                 {
                  Text = "IMCA",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(18)
                 },
                    l5 ,
                


                    }
                }
            };

         
                Children.Add(first_page);
               Children.Add(second_page);
              Children.Add(third_page);
               Children.Add(forth_page);
               Children.Add(fifth_page);
        
           

         



        }
     

}
    
    
}





