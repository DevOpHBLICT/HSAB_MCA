using pharm_dbb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;
using Xamarin.Forms;

namespace pharm_dbb
{

    public class d : ContentPage
    {

        Button home;
        Button back;

        private string sp;
        private string t;
        private string yesnext;
        private string nonext;
        String _BGColor;

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            if (sp == "20")
            {
                _BGColor = "#d99694";
                t = "Best Interest Decision";
            }
            var tg = new d(yesnext, t, _BGColor);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }
        void OnnoButtonClicked(object sender, EventArgs e)
        {
            if (sp == "20")
            {
                _BGColor = "#953735";
                t = "Assessing Capacity Prompts";
            }
            var tg = new d(nonext,t, _BGColor);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }
        void BackButtonClicked(object sender, EventArgs e)
        {
            back.IsEnabled = false;

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }
        void HomeButtonClicked(object sender, EventArgs e)
        {

            var page = Navigation.NavigationStack.First();
            while (page.Navigation.NavigationStack.Count>1)
            { page.Navigation.PopAsync(); }

         


        }
        public void Mental_Capacity_Assessments_Info_Clicked(object sender, EventArgs args)
        {
            var tg = new info_2("Assessing Capacity Prompts");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public void Best_Interest_Decision_Info_Clicked(object sender, EventArgs args)
        {
            var tg = new info_2("Best Interests Decision");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public void IMCA_Referrals_Info_Clicked(object sender, EventArgs args)
        {
            var tg = new info_2("IMCA Referrals");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public void DOLS_Appplication_Info_Clicked(object sender, EventArgs args)
        {
            var tg = new info_2("DOLS Applications");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


      


       

       






        public d(string startpage, String Titles, String BGColor)
        {
            t = Titles;
          
            sp = startpage;

           
          
         

                  String yesenabled = "";
            String noenabled = "";
         
            String printout ="";
       
            foreach (var p in App.pages)
                {
                    if (p.id == startpage)
                    {
                        yesnext = p.yesnext;
                        nonext = p.nonext;
                        yesenabled = p.yesbutton;
                        noenabled = p.nobutton;
                        printout = p.description;
               
                    }

           

            }
         
            if (printout=="")
            {
                List<Pages> pages = new List<Pages>();

                pages.Add(new Pages { description = "Does the person understand the decision you are asking them to make?", id = "1", yesbutton = "1", nobutton = "1", yesnext = "3", nonext = "2" });
                pages.Add(new Pages { description = "A persons capcity must be assessed specifically in terms of their capacity to make a particular decision at the time it needs to be made.", id = "2" });
                pages.Add(new Pages { description = "The Mental Capacity Act generally does not apply to people under the age of 16yrs. Is the person age 16 yrs?", id = "3", yesbutton = "1", nobutton = "1", yesnext = "5", nonext = "4" });
                pages.Add(new Pages { description = "Care and treatment of children under the age of 16 is governed by common law principles. \r\n No powers under the MCA may be excercised in relation to a child under 16yrs.\r\n Alternative guidance for those under the age of 16 can be found by looking at the specific laws in relation to capacity and those under 16.", id = "4" });
                pages.Add(new Pages { description = "Have you started the assessment process with the assumption that the person has capacity to make the specific decision?", id = "5", yesbutton = "1", nobutton = "1", yesnext = "7", nonext = "6" });
                pages.Add(new Pages { description = "You must always begin with the assumption that the person has capacity to make a particular decision unless it can be established that they lack capacity.", id = "6" });
                pages.Add(new Pages { description = "Has the person made their own decision?", id = "7", yesbutton = "1", nobutton = "1", yesnext = "9", nonext = "8" });
                pages.Add(new Pages { description = "All practical and appropriate steps must be taken to help people to make a decision for themselves. Information must be tailored to an individual's needs and abilities. It must also be in the easiest and most appropriate form of communication for the person concerned.", id = "8" });
                pages.Add(new Pages { description = "A person is not to be treated as unable to make a decision because you consider it to be unwise. Is this the situation?", id = "9", yesbutton = "1",nobutton="1", yesnext = "10" ,nonext="11"});
                pages.Add(new Pages { description = "Everyone has their own values, beliefs, preferences and attitudes. A person should not be assumed to lack the capacity to make a decision just because other people think their decision is unwise.", id = "10" });
                pages.Add(new Pages { description = "Does the person have an impairment of the mind or brain, or some sort of disturbance that affects the way their mind or brain works?", id = "11", yesbutton = "1", nobutton = "1", yesnext = "13", nonext = "12" });
                pages.Add(new Pages { description = "The person does not lack capacity as defined within the Mental Capacity Act and is therefore capable of consenting to a decision or refusing treatment. \r\n Examples of an impairment or disturbance in the functioning of the mind or brain may include the following: \r\n \u2022 conditions associated with some forms of mental illness \r\n\u2022 dementia \r\n\u2022 significant learning disabilities \r\n \u2022 the long term effects of brain damage \r\n \u2022 physical or medical conditions that cause confusion, drowsiness or loss of consciousness\r\n \u2022 delirium  \r\n \u2022 concussion following a head injury \r\n \u2022 the symptoms of alcohol or drug use", id = "12" });
                pages.Add(new Pages { description = "1. Can the person understand the information about the decision to be made? \r\n (Failure of one or more of these points will determine a lack of capacity and a Best Interests Decision will need to be made.)", id = "13", yesbutton = "1", nobutton = "1", yesnext = "15", nonext = "14" });
                pages.Add(new Pages { description = "Every effort must be made to provide information in a way that is most appropriate to help the person to understand. Quick or inadequate explanations are not acceptable unless the situation is urgent. Relevant information includes: \r\n \u2022 the nature of the decision \r\n \u2022 the reason why the decision is needed \r\n\u2022 the likely effects of deciding one way or another, or making no decision at all. If still unable to understand. \r\n Proceed to Best Interest Decision section", id = "14", yesbutton = "6", yesnext = "22" });
                pages.Add(new Pages { description = "2. Can the person hold the information in their mind long enough to be able to make an effective decision?", id = "15", yesbutton = "1", nobutton = "1", yesnext = "17", nonext = "16" });
                pages.Add(new Pages { description = "If the person is unable to retain the information for long enough to make the decision and this is caused by a disturbance of the mind or brain, they lack capacity to make the decision. \r\n Proceed to Best Interest Decision", id = "16", yesbutton = "6", yesnext = "22" });
                pages.Add(new Pages { description = "3. Can the person evaluate the relevant information to make the decision? ", id = "17", yesbutton = "1", nobutton = "1", yesnext = "19", nonext = "18" });
                pages.Add(new Pages { description = "If the person is unable to evaluate the relevant information and this is caused by a disturbance of the mind or brain, they lack capacity to make the decision. Proceed to Best Interest Decision section", id = "18", yesbutton = "6", yesnext = "22" });
                pages.Add(new Pages { description = "4. Can the person communicate their decision by any means (e.g. speech, sign language)?", id = "19", yesbutton = "1", nobutton = "1", yesnext = "55", nonext = "20" });
                pages.Add(new Pages { description = "If the person is unable to communicate their decision in any way and this is caused by a disturbance of the mind or brain, they lack capacity to make the decision. Proceed to Best Interest Decision", id = "20", nobutton = "0", yesbutton = "9", yesnext = "22" });
                pages.Add(new Pages { description = "Other considerations:\r\n You must try to determine if the person has a valid advance decision to refuse the treatment you wish to give in their best interest ?\r\n Who else can make a decision in someone''s best interest if they are found to lack capacity ? \r\n \u2022 donee of a Lasting Power of Attorney Health and Welfare or Financial / Court Appointed Deputy \r\n \u2022 Independent Mental Capacity Advocate(IMCA) \r\n \u2022 Clinician or other decision maker ", id = "21" });
                pages.Add(new Pages { description = "If the person is found to lack capacity for the decision and requires someone to act in their best interests, that person could be:\r\n \u2022 Someone with Lasting Power of Attorney(LPA) or Court Appointed Deputy \r\n \u2022 Independent Mental Capacity Advocate(IMCA) \r\n \u2022 Clinician or other decision maker ", id = "22", yesbutton = "3", yesnext = "23" });
                pages.Add(new Pages { description = "Is this a health or social care decision where a simple response is needed? E.g. there is no requirement to involve the Court of Protection etc.", id = "23", yesbutton = "1", nobutton = "1", yesnext = "25", nonext = "24" });
                pages.Add(new Pages { description = "If the intervention required is urgent or an emergency – <b>you must proceed without delay</b>. \r\n In all other circumstances apply the best interests checklist (found in the MCA code of practice) to the decision to be made and the decision maker in consultation with carers, IMCA or other relevant individuals must decide what is in the persons best interest.", id = "24" });
                pages.Add(new Pages { description = "Have you involved/consulted with others (partner, relatives or carers) who know the persons wishes and can speak on their behalf?", id = "25", yesbutton = "1", nobutton = "1", yesnext = "27", nonext = "26" });
                pages.Add(new Pages { description = "If it is practicable and appropriate, you must consult with at least one person to speak on behalf of the person to determine the past and present wishes, feelings, beliefs and values to find out what they would consider to be in their best interests.  \r\n If there is no one to speak on the persons behalf, it may be appropriate to consider requesting an Independent Mental Capacity Advocate(IMCA)", id = "26", yesbutton = "8", yesnext = "38" });
                pages.Add(new Pages { description = "Have you avoided making assumptions based on the persons age, appearance, condition or behaviour?", id = "27", yesbutton = "1", nobutton = "1", yesnext = "29", nonext = "28" });
                pages.Add(new Pages { description = "You should never make decisions for the person based on personal judgments as these could be considered to be discriminatory.", id = "28" });
                pages.Add(new Pages { description = "Can you determine the person previous wishes or find any statements made when they still had capacity that will assist you to make this decision?", id = "29", yesbutton = "1", nobutton = "1", yesnext = "30", nonext = "31" });
                pages.Add(new Pages { description = "The previous decisions of the person, now lacking capacity, take precedence over partners, relatives and other parties.\r\n Advance statements(verbal or written) when the person had capacity are not legally binding but the decision maker is legally bound to take into account and cannot ignore it.\r\n Is there an Advance Decision to refuse treatment in existence that conflicts with the decision to be made as this is legally binding even if others disagree.", id = "30" });
                pages.Add(new Pages { description = "Is capacity likely to improve or return?", id = "31", yesbutton = "1", nobutton = "1", yesnext = "32", nonext = "33" });
                pages.Add(new Pages { description = "\r\n Postpone the decision until capacity has returned if it is a non urgent decision.", id = "32" });
                pages.Add(new Pages { description = "Can the decision wait until capacity returns?", id = "33", yesbutton = "1", nobutton = "1", yesnext = "34", nonext = "35" });
                pages.Add(new Pages { description = "\r\n Postpone the decision until capacity has returned.", id = "34" });
                pages.Add(new Pages { description = "Have you considered the least restrictive option?", id = "35", yesbutton = "1", nobutton = "1", yesnext = "37", nonext = "36" });
                pages.Add(new Pages { description = "You must consider all the factors in the decision and determine which is the least restrictive physically, psychologically and socially for the person.  If a more restrictive option is chosen and it amounts to a deprivation of liberty(depending on the circumstances) you may need to consider a Deprivation of Liberty Safeguards(DoLS) application.", id = "36", yesbutton = "5", yesnext = "42", nonext = "37" });
                pages.Add(new Pages { description = "\r\n Proceed to making the decision and document how the decision was made on the relevant forms.", id = "37" });
                pages.Add(new Pages { description = "An Independent Mental Capacity Advocate (IMCA) must be instructed when the person is found to lack capacity and a best interest decision is needed and the person has no appropriate person (friends or family) to consult on the following decisions:\r\n \u2022  Serious medical treatment \r\n \u2022  A change of accommodation ", id = "38", yesbutton = "3", yesnext = "39" });
                pages.Add(new Pages { description = "In addition, there is a duty in the NHS and social care settings to consider requesting an IMCA in the following circumstances: \r\n \u2022 Safeguarding Adults from Abuse\r\n \u2022 Care Reviews  ", id = "39", yesbutton = "3", yesnext = "40" });
                pages.Add(new Pages { description = "The IMCA’s role in these circumstances is to:\r\n \u2022 Gather the views and beliefs of person \r\n \u2022 Evaluate all the relevant information \r\n \u2022 Provide a written report to assist the decision maker (e.g.Doctor) ", id = "40", yesbutton = "3", yesnext = "41" });
                pages.Add(new Pages { description = "If you need to instruct an IMCA please contact the Hertfordshire service (POhWER) via:\r\n Email: <a href='mailto: pohwer@pohwer.net'>pohwer@pohwer.net</a><br>Website:<a href='http://www.pohwer.net/index-13.html'>POhWER</a><br>Telephone:<a href= 'tel:0300 456 2370'>0300 456 2370</a> ", id = "41" });
                pages.Add(new Pages { description = "The Supreme Court has found that the test to determine if the person is being deprived of their liberty depends on 3 criteria:\r\n \u2022 The person lacks mental capacity to decide to remain in the care setting \r\n \u2022 The person is under continuous supervision and control <b>and</b> \r\n \u2022 The person is not free to leave the care setting. ", id = "42", yesbutton = "3", yesnext = "43" });
                pages.Add(new Pages { description = "Can the person consent to remain in the care setting following a mental capacity assessment?", id = "43", yesbutton = "1", nobutton = "1", yesnext = "46", nonext = "44" });
                pages.Add(new Pages { description = "Have you completed your organisations MCA & BID forms for this decision?", id = "44", yesbutton = "1", yesnext = "45" });
                pages.Add(new Pages { description = "Is the person 18yrs or older?", id = "45", yesbutton = "1", nobutton = "1", yesnext = "47", nonext = "46" });
                pages.Add(new Pages { description = "The person does not meet the DoLS assessment criteria.\r\n Please review the persons care plan, allow them to leave, documenting the unwise decision, or consider applying the Mental Health Act or seek legal advice.", id = "46" });
                pages.Add(new Pages { description = "Does the person have a mental disorder? (such as dementia, learning disability, confusion, concussion, etc?) ", id = "47", yesbutton = "1", nobutton = "1", yesnext = "57", nonext = "48" });
                pages.Add(new Pages { description = "The person does not meet the DoLS assessment criteria.\r\n Please review the persons care plan, allow them to leave, documenting the unwise decision, or consider applying the Mental Health Act or seek legal advice.", id = "48" });
                pages.Add(new Pages { description = "Is there no less restrictive way to provide the care the person needs?", id = "57", yesbutton = "1", nobutton = "1", yesnext = "51", nonext = "52" });
                pages.Add(new Pages { description = "The person appears to have capacity to give valid consent for this decision. Please document this assessment in the persons record", id = "50" });
                pages.Add(new Pages { description = "Please review the persons care arrangements to minimise restriction and record rationale in the persons care records.", id = "51" });
                pages.Add(new Pages { description = "Does the person meet the criteria for detention under the Mental Health Act?", id = "52", yesbutton = "1", nobutton = "1", yesnext = "54", nonext = "56" });
                pages.Add(new Pages { description = "A person is not eligible for the Deprivation of Liberty Safeguards if they are eligible for assessment under the Mental Health Act.", id = "54" });
                pages.Add(new Pages { description = "The person appears to have capacity to give valid consent for this decision. Please document this assessment in the persons record.", id = "55" });
                pages.Add(new Pages { description = "The person meets the criteria for a DoLS application, this application can be completed in 2 parts on the same combined form:\r\n Urgent Authorisation(self authorise for max. 7 days)\r\n Standard Application \r\n When making your application to the DOLS team, please ensure that all relevant information relating to any Lasting Power of Attorney, Advance Decision or Court of Protection order is included in the application. Contact and send the application form to the DoLS team dolsteam@hertfordshire.gov.uk as per your local process.", id = "56" });







                 yesenabled = "";
                 noenabled = "";
                 printout = "";
                foreach (var p in pages)
                {
                    if (p.id == startpage)
                    {
                        yesnext = p.yesnext;
                        nonext = p.nonext;
                        yesenabled = p.yesbutton;
                        noenabled = p.nobutton;
                        printout = p.description;
                    }

                };
            }
            t = Titles;
            Title = Titles;
            _BGColor = BGColor;
            BackgroundColor = Color.White;

            Label Conclusion = new Label()
            {
                TextColor = Color.Black,
                Text = "Conclusion",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            .WithAttributes(FontAttributes.Bold)
            };
            Conclusion.IsVisible = false;
            if ((startpage == "56") || (startpage == "55") || (startpage == "54") || (startpage == "51") || (startpage == "50") || (startpage == "41") || (startpage == "37") || (startpage == "34") || (startpage == "32") || (startpage == "30") || (startpage == "28") || (startpage == "24") || (startpage == "21") || (startpage == "12") || (startpage == "10") || (startpage == "8") || (startpage == "6") || (startpage == "4") || (startpage=="2")|| (startpage == "12") || (startpage == "56") || (startpage == "54") || (startpage == "55") || (startpage == "53") || (startpage == "51") || (startpage == "48") || (startpage == "46") || (startpage == "37") || (startpage == "34") || (startpage == "32"))
            {
                Conclusion.IsVisible = true;
            }



            Label title = new Label
            {
             BackgroundColor = Color.FromHex(BGColor),
             Text = Titles,
             XAlign = TextAlignment.Center,
             Font = Font.SystemFontOfSize(30)
                
            };
            if (Titles == "Assessing Capacity Prompts")
            {
                title.TextColor = Color.White;
            }
            else
            {
                title.TextColor = Color.FromHex("#953735");
            }
           // title.WidthRequest = 50;
           // title.HeightRequest = 50;
           home = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, IsEnabled = true };
            Button info = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, IsEnabled = true };


            home.Image = (FileImageSource)ImageSource.FromFile("home.png");
            info.Image= (FileImageSource)ImageSource.FromFile("info.png");


            home.HorizontalOptions = LayoutOptions.End;
            home.VerticalOptions = LayoutOptions.End;
            back = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Image = "back", IsEnabled = true };
            back.Image = (FileImageSource)ImageSource.FromFile("back.png");
            back.HorizontalOptions = LayoutOptions.End;
            back.VerticalOptions = LayoutOptions.End;
            home.BorderWidth = 1;
            back.BorderWidth = 1;
            info.BorderWidth = 1;
            info.TextColor = Color.Black;
            home.BorderColor = Color.FromHex(BGColor);
            back.BorderColor = Color.FromHex(BGColor);
            info.BorderColor = Color.FromHex(BGColor);



            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            else
            {
                back.IsVisible = false;
                home.IsVisible = false;
                info.IsVisible = false;
                title.IsVisible = false;
            }



            if (Titles == "Assessing Capacity Prompts")
            {
                info.Clicked += Mental_Capacity_Assessments_Info_Clicked;
            }

            if (Titles == "Best Interests Decision")
            {
                info.Clicked += Best_Interest_Decision_Info_Clicked;
            }
            if (Titles == "IMCA Referrals")
            {
                info.Clicked += IMCA_Referrals_Info_Clicked;
            }
            if (Titles == "DOLS Applications")
            {
                info.Clicked += DOLS_Appplication_Info_Clicked;
            }


            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "Yes", IsVisible = false, Image = "tick", BackgroundColor = Color.FromHex("#953735"),TextColor=Color.White };
            yes.Image = (FileImageSource)ImageSource.FromFile("tick.png");
            Button no = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "No", IsVisible = false, Image = "cross", BackgroundColor = Color.FromHex("#bfbfbf"),TextColor=Color.White };
            no.Image = (FileImageSource)ImageSource.FromFile("cross.png");

            if (Device.OS == TargetPlatform.iOS)
            {
                yes.TextColor = Color.White;
                no.TextColor = Color.White;
            }

                yes.HeightRequest =60;
            no.HeightRequest = 60;
            home.WidthRequest = 110;
            back.WidthRequest = 110;
            info.WidthRequest = 110;
            yes.Clicked += OnyesButtonClicked;
            no.Clicked += OnnoButtonClicked;
            home.Clicked += HomeButtonClicked;    
            back.Clicked += BackButtonClicked;
            if (noenabled == "1") { no.IsVisible = true; };
            if (yesenabled == "1") { yes.IsVisible = true; };
            if (yesenabled == "3") { yes.IsVisible = true; yes.Text = "Next"; }


            if (yesenabled == "8")
            {
                yes.IsVisible = true; yes.Text = "Proceed to IMCA"; t = "IMCA Referrals";
                _BGColor = "##e6b9b8";

            }


            if (yesenabled == "6")
            {
                yes.IsVisible = true; yes.Text = "Proceed to Best Interest Decision"; t = "Best Interest Decision";
                _BGColor = "#d99694";

            }
            if (yesenabled == "7")
            {
                no.IsVisible = true; no.Text = "Next";
                no.Image = "";
                yes.IsVisible = true; yes.Text = "Proceed to Best Interest Decision"; t = "Best Interest Decision";
                _BGColor = "#d99694";

            }
            if (yesenabled == "4") {
                no.IsVisible = true;no.Text = "Next";
                no.Image = "";
                yes.IsVisible = true; yes.Text = "Proceed to Best Interest Decision"; t = "Best Interest Decision";
                _BGColor = "#d99694";
              
            }
            if (yesenabled == "9")
            {
                no.IsVisible = false; ;
                yes.Image = "";
                yes.IsVisible = true; yes.Text = "Proceed to Best Interest Decision"; t = "Best Interest Decision";
                _BGColor = "#d99694";

            }


            if (yesenabled == "5")
            {
                yes.IsVisible = true; yes.Text = "Proceed to DOLS Applications"; t = "DOLS Applications";
                _BGColor = "#d99694";

            }
            var output1   = new Label();
            output1.Text = printout;
            output1.TextColor = Color.Black;
            output1.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

          
            var output2  = new WebView();
            output1.IsVisible = false;
            output2.IsVisible = false;
            var htmlSource = new HtmlWebViewSource();
            //   htmlSource.Html = "<div style='background-color:transparent;padding:5px;width=100%;font-size:20px'>" + k.Description + "</div><div style=';padding:5px;width=100%;'></div><p>";
            htmlSource.Html = "<div style='background-color:white;padding:5px;width=100%;font-size:18px'>" + printout + "</div><div style=';padding:5px;width=100%;'></div><p>";
            output2.HeightRequest = 400;
            output2.WidthRequest = 500;
            output2.Source = htmlSource;

            if ((startpage == "41")||(startpage=="42")||(startpage=="24")) {
                output2.IsVisible = true;
            }
            else
            {
                output1.IsVisible = true;
            }

         

                //  browser.BackgroundColor = Color.Transparent;
                //  browser.IsEnabled = false;

                var l = new StackLayout
            {
         //       BackgroundColor = Color.FromHex(BGColor),
                
                VerticalOptions= LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children =
                        {
                            title,
                        }
            };
            var m = new StackLayout
            {
              //  BackgroundColor = Color.FromHex(BGColor),
                Spacing=20,
                Padding = new Thickness(1, 1, 1, 1),
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children =
                        {
                            back,
                            home,
                            
                            info
                        }
            };
            var s = new StackLayout
            {
                  Padding = new Thickness(10, 10, 10, 10),
                //   BackgroundColor = Color.White,

                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    Conclusion,
              output1,output2
                 //   browser,
                  
           }
            };
            var x = new StackLayout
            {
               
                Padding = new Thickness(10, 10, 10, 10),
                Children = {
                    title,m,s,
                    yes,
                    no,
                //    l
                new Label()
                }
            };


            Content = new ScrollView { Content = x };
                


        }
    }
}
