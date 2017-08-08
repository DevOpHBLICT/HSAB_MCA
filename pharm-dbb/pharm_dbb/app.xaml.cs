using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace pharm_dbb
{
    public class App : Application
    {
        public static string data;
        public static string version_no;
        public static string current_version;
        public static int loaded;
        public static int Network_Connection;
        public static List<Pages> pages = new List<Pages>();

        public static String app_title { get; set; }

        public static NavigationPage NavPage { get; set; }

        public App()
        {
            loaded = 0;
            Resources = new ResourceDictionary();
            Resources.Add("Wine_Red", Color.FromHex("953735"));
            NavPage = new NavigationPage(new Contents());
            if (Device.OS != TargetPlatform.Windows)
            {
                App.NavPage.BarBackgroundColor = (Color)App.Current.Resources["Wine_Red"];
                App.NavPage.BarTextColor = Color.White;
                App.NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    //  Text = "Home",
                    //    Icon ="back.png",
                    Icon = "home.png",
                    //    Command = new Command(() => nav.PushAsync(new Contents(database))),
                    Command = new Command(() => App.NavPage.PopToRootAsync())
                });
                App.NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    Text = "i",
                    Icon = "info2.png",

                    Command = new Command(() =>

                        App.NavPage.PushAsync(new info_2(app_title))

                     )
                });
            }
            MainPage = NavPage;

        }

     


        async static void GetOnlineData()
        {
            MovieCollection res = new MovieCollection();
            const string fileName = "Mental_Capacity.txt";
            var fileService = DependencyService.Get<ISaveAndLoad>();
           data = "";
            try
            {
                string Url = String.Format("https://onedrive.live.com/download?cid=2B765942C77D4869&resid=2B765942C77D4869%21173&authkey=ADv_kBeaPSLyM70");
                HttpClient hc = new HttpClient();
              
               data= await hc.GetStringAsync(Url);
                Network_Connection = 1;
             
            }
            catch (System.Exception sysExc)
            {
                Network_Connection = 0;
              
            }
            // Parse JSON into dynamic object, convenient! 
            JArray results = JArray.Parse(data);

            foreach (JObject o in results.Children<JObject>())
            {
                string id = "";
                string description = "";
                string yesbutton = "";
                string nobutton = "";
                string yesnext = "";
                string nonext = "";

                foreach (JProperty p in o.Properties())
                {
                    string name = p.Name;
                    if (name == "description")
                    {
                        description = (string)p.Value;
                    }
                    if (name == "id")
                    {
                        id = (string)p.Value;
                    }
                    if (name == "yesbutton")
                    {
                        yesbutton = (string)p.Value;
                    }
                    if (name == "nobutton")
                    {
                        nobutton = (string)p.Value;
                    }
                    if (name == "yesnext")
                    {
                        yesnext = (string)p.Value;
                    }
                    if (name == "nonext")
                    {
                        nonext = (string)p.Value;
                    }

                    pages.Add(new Pages { description = description, id = id, yesbutton = yesbutton, nobutton = nobutton, yesnext = yesnext, nonext = nonext });

                }




            }
            loaded = 1;
        }




        public static ListView p;


        async static void CheckVersion()
        {

            var fileService = DependencyService.Get<ISaveAndLoad>();
            var i = "";
          
                string Url = String.Format("https://onedrive.live.com/download?cid=2B765942C77D4869&resid=2B765942C77D4869%21173&authkey=ADv_kBeaPSLyM70");
                HttpClient hc = new HttpClient();
           
               version_no = await hc.GetStringAsync(Url);

            i = version_no;
        }
        async static void SaveOnlineData()
        {
            var fileService = DependencyService.Get<ISaveAndLoad>();
            await fileService.SaveTextAsync("Mental_Capacity.txt", data);
        }

        async static void LoadCurrentData()
        {

            var fileService = DependencyService.Get<ISaveAndLoad>();
            current_version = await fileService.LoadTextAsync("Mental_Capacity_Version.txt");
        }
            async static void CheckCurrentVersion()
        {
            var fileService = DependencyService.Get<ISaveAndLoad>();
            try
            {
                current_version = await fileService.LoadTextAsync("Mental_Capacity_Version.txt");
            }catch
            {
                current_version = "0";
            }
        }
     
        protected override void OnStart()
        {
        //    CheckCurrentVersion();

        //    CheckVersion();


        //    if (Convert.ToInt32(version_no) > Convert.ToInt32(current_version))
        //    {
        //        GetOnlineData();
        //    }

               
        //    SaveOnlineData();

           
            var st = "\t\u2022 This app is intended for use by Health and Social Care Professionals. ";
            st = st + "It is meant to be used as an aid  for decision making and does not replace clinical judgement\r\n";
            st = st + "\t\u2022 Click on each button and information section to see more guidance\r\n ";
            st = st + "\t\u2022 This app will not provide enough information to adequately document the decision or decision making process, it is essential that you document all decisions, how they were made and who else was involved\r\n ";
            st = st + "\t\u2022 This app is an adjunct to your organisations policies\r\n ";
            st = st + "\t\u2022 The guidance in this app does not relate to a Deprivation of Liberty in the persons own home\r\n ";


            var answer =  App.Current.MainPage.DisplayAlert("Disclaimer", st, "I agree");
            // Handle when your app starts
        }




        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
    }
}