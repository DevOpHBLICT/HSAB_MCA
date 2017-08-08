
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{



    public class GetData
    {
        public Color Image { get; set; }

        public string Name { get; set; }


    }

    public static class ContentsData
    {
    }

    public class Contents : ContentPage
    {
     

       


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

        public void Mental_Capacity_Assessments_Clicked(object sender, EventArgs args) {
            App.app_title = "Assessing Capacity Prompts";
            var tg = new d("1", "Assessing Capacity Prompts", "#953735");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
      
        }
        public void Best_Interest_Decision_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Best Interests Decision";
            var tg = new d("22", "Best Interests Decision", "#d99694");
          Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
     
        }
     
        public void IMCA_Referrals_Clicked(object sender, EventArgs args)
        {
            App.app_title = "IMCA Referrals";
            var tg = new d("38", "IMCA Referrals", "#e6b9b8"); ;
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
           
        }
     

        public void DOLS_Appplication_Clicked(object sender, EventArgs args)
        {
            App.app_title = "DOLS Applications";
            var tg = new d("42", "DOLS Applications", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
     

        public Contents()
        {


            App.app_title = "HSAB MCA Prompts";
            Title = "HSAB MCA Prompts";
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            { 
                NavigationPage.SetHasNavigationBar(this, false);
            }

                BackgroundColor = Color.White;

                title = new Label
                {
                    Text = "HSAB MCA Prompts",
                XAlign = TextAlignment.Center,
                 Font = Font.SystemFontOfSize(30),
                    BackgroundColor=Color.White
                };

                title.TextColor = Color.FromHex("#953735");
          
            //  var pharm = database.GetContents();

            //  BackgroundImage = "people.jpg";
            Button Mental_Capacity_Assessments = new Button {  Text = "Assessing Capacity prompts", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White, VerticalOptions=LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Best_Interest_Decision = new Button {  Text = "Best Interests Decision prompts", BackgroundColor = Color.FromHex("#d99694"), TextColor = Color.FromHex("#953735"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand , FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
             Button IMCA_Referrals = new Button { Text = "IMCA Referrals prompts", BackgroundColor = Color.FromHex("#e6b9b8"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button DOLS_Applications = new Button { Text = "DOLS Applications prompts", BackgroundColor = Color.FromHex("#bfbfbf"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
 

            if (Device.OS == TargetPlatform.Windows)
            {
                 Mental_Capacity_Assessments.HeightRequest = 90;
                Best_Interest_Decision.HeightRequest = 90;
                DOLS_Applications.HeightRequest = 90;
                IMCA_Referrals.HeightRequest = 90;
                Mental_Capacity_Assessments.BorderColor = Color.White;
                Best_Interest_Decision.BorderColor = Color.White;
                 IMCA_Referrals.BorderColor=Color.White;
                 DOLS_Applications.BorderColor = Color.White;
  
            }


            Mental_Capacity_Assessments.Clicked += Mental_Capacity_Assessments_Clicked;
             Best_Interest_Decision.Clicked += Best_Interest_Decision_Clicked;
            IMCA_Referrals.Clicked += IMCA_Referrals_Clicked;
            DOLS_Applications.Clicked += DOLS_Appplication_Clicked;
 
        this.Padding = new Thickness(5, 5, 5, 5);
            var StackPanel = new StackLayout
            {
          
             //        BackgroundColor = Color.White,
                Children =
                {


                    new Image {

                           //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source =ImageSource.FromFile( "contents.png" )}

                        ,
                //    listView,
                new StackLayout
                {
                    Spacing =1,
                    Orientation=StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children= {

                Mental_Capacity_Assessments,
             //   Mental_Capacity_Assessments_Info
                }
                },

                    new StackLayout
                {
                    Spacing =1,
                     VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation=StackOrientation.Horizontal,
                    Children= {

                Best_Interest_Decision,
               // Best_Interest_Decision_Info
                }
                },

  new StackLayout
                {
                    Spacing =1,
                    Orientation=StackOrientation.Horizontal,
                     VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children= {

                IMCA_Referrals,
               // IMCA_Referrals_Info,
                }
                },

  new StackLayout
                {
                      Spacing =1,
                       VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation=StackOrientation.Horizontal,
                    Children= {
                    DOLS_Applications,
               // DOLS_Applications_Info,
                }
                },

  new StackLayout
  {
       VerticalOptions = LayoutOptions.FillAndExpand,
       HorizontalOptions = LayoutOptions.FillAndExpand,
      Orientation=StackOrientation.Horizontal,
      BackgroundColor=Color.White,
      Padding=5,
      Children= {
             new Image {
 
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.StartAndExpand,
                           HeightRequest=90,
                           WidthRequest=180,
                                  Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "HSAB_logo1.png" )},

          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.EndAndExpand,
                          HeightRequest=45,
                           WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hbl.png" )},
                           
      }
  },
                 
                              
                        }

            };

            if (Device.OS == TargetPlatform.Windows)
            {
          StackPanel.Children.Insert(0, title);
          
            }

            Content = StackPanel;
        }
    }
}