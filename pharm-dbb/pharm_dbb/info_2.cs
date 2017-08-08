using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using Version.Plugin;
namespace pharm_dbb


{



    public class info_2 : CarouselPage
    {
        string s = "";
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        string e = "";

       
        void BackButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }

        public info_2(String info)
        {
            BackgroundColor = Color.White;
         
            Title = info;
            // Label title = null;
            Button home = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "home", TextColor = Color.Black };
            home.IsVisible = false;
            if (Device.OS == TargetPlatform.Windows)
            {
                   Button back = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Image = "back" };
                Button next = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "next", TextColor = Color.Black };
                back.Image = (FileImageSource)ImageSource.FromFile("back.png");
                back.HorizontalOptions = LayoutOptions.End;
                back.VerticalOptions = LayoutOptions.End;
                back.BackgroundColor = Color.Transparent;

                back.Clicked += BackButtonClicked;
                home.IsVisible = true;
                BackgroundColor = Color.White;
                NavigationPage.SetHasNavigationBar(this, false);
                //   this.TranslationY = -40;
            }

            Label LItalic = new Label
            {
             //    HorizontalTextAlignment = TextAlignment.Center,

            };

            var fs = new FormattedString();
        
            fs.Spans.Add(new Span { ForegroundColor = Color.Black, FontSize = 14, FontAttributes = FontAttributes.Italic, Text = "'The requirement for continuous / complete supervision and control cannot and should not be interpreted as requiring 24 hour monitoring and/or that the person is to be physically accompanied over a continuous 24 hour period. In other words, if the individual is subject to such monitoring or such degree of accompaniment, then the necessary degree of continuity or completeness will be satisfied. But it is capable of being satisfied even if the supervision and control is 'lighter touch'" });
            



            Label title2 = new Label
            {
                Text = "Additional information",
                HorizontalTextAlignment = TextAlignment.Center,
                Font = Font.SystemFontOfSize(14)

            };
            title2.TextColor = Color.FromHex("#953735");
            Label l1 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l1.TextColor = Color.Black;
            l1.IsEnabled = true;

            Label l2 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l2.TextColor = Color.Black;
            l2.IsEnabled = true;

            Label l3 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l3.TextColor = Color.Black;
            l3.IsEnabled = true;

            Label l4 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l4.TextColor = Color.Black;
            l4.IsEnabled = true;
            Label l5 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l5.TextColor = Color.Black;
            l5.IsEnabled = true;
            if (info == "HSAB MCA Prompts")
            {
               
                a = "Version:" +CrossVersion.Current.Version + " \r\n\r\n Copyright HSAB and HBL \r\n\r\n This app has been designed for use as an aide memoire for the application of the Mental Capacity Act by professionals including health and social care staff. \r\n\r\n The following staff developed this app: \r\n Tracy Cooper \r\n Jane Newcombe \r\n Neil Wallace \r\n Caroline Raut \r\n\r\n The responsible officers for this app are:\r\n Caroline.Aitken@Hertfordshire.gov.uk or Lorraine.Waterworth@Hertfordshire.gov.uk";
                l1.Text = a;
            }

            if (info == "Assessing Capacity Prompts")
            {
                a = a + "\u2022It is assumed that adults over 16 years of age have full legal capacity to make decisions for themselves unless it can be shown that they lack capacity to make a decision for themselves at the time it needs to be made.\r\n\r\n ";
                a = a + "\u2022Lack of capacity according the MCA code of practice is defined as the individual being unable to make a particular decision or take a particular action for themselves at the time the decision or action needs to be taken because of an impairment or disturbance of the mind or brain.\r\n\r\n";
                a = a + "\u2022A person may lack capacity to make some decisions for themselves but will have capacity to make other decisions e.g. they may have capacity to make small decisions about everyday issues such as what to wear or what to eat, but lack capacity to make more complex decisions about financial matters.\r\n\r\n ";
                a = a + "\u2022A persons capacity must not be judged simply on the basis of their age, appearance, condition or any aspect of their behaviour i.e. Appearance – this includes physical characteristics of certain conditions i.e. down's syndrome, scars, skin colour, tattoos, or body piercing. Condition – includes physical disabilities, Learning disabilities, illness related to age, drunkenness, extrovert or introvert behaviour \r\n\r\n CONT->";
                b = "\u2022Information must be provided in a way that the individual understands. Different methods of communication must be considered i.e. pictures, DVD, written information. Steps must be taken to provide information in a way that reflects the person’s individual circumstances and meets their needs i.e. a person with LD will have different needs to a person with dementia. Take time to explain, don’t give more detail than is required, use simple language, speak slower, repeat information, is there anyone who can support them make a decision? \r\n\r\n";
                b = b + "\u2022Principal 3 of the MCA states that a person is not to be treated as unable to make a decision merely because he makes an unwise one. Everyone has their own values, beliefs, preferences and attitudes. There may be concern if the person repeatedly makes unwise decisions, which put them at significant risk of harm or exploitation. \r\n\r\n";
                b = b+ "\u2022Stage 1 requires proof that the person has impairment or disturbance of the mind or brain.  This will affect the way their mind works. It doesn’t matter if this is permanent or temporary. Examples of impairment include: delirium, significant Learning disability, long term effects of brain damage, physical or medical conditions that cause confusion, drowsiness or loss of consciousness, dementia, symptoms of drug/ alcohol abuse.\r\n\r\n CONT->";
                c =  "\u2022A person may lack capacity to make a decision for themselves at a certain time may be able to make that decision at a later date because they have an illness or condition that means their capacity changes.\r\n\r\n ";
                c = c + "\u2022It is important not to assess someone's understanding before they have been given the relevant information, presented in a way that is appropriate to their individual needs. Relevant information includes: - the nature of the decision, why the decision is needed, and the likely effects of deciding one way or the other.\r\n\r\n";
                c = c + "\u2022The person must be able to retain the information long enough to use it to make an effective decision. The MCA states that people who can only retain information for a short while must not automatically be assumed to lack capacity.\r\n\r\n";
                c = c + "\u2022For someone to have capacity they must have the ability to weigh up and use the information to arrive at a decision. Sometimes people can understand but impairment or disturbance of the brain stops them using the information or they can make a decision without understanding the information.\r\n\r\n";
                c = c +  "\u2022If a person is unable to communicate in any way at all they must be treated as lacking capacity. It is important to make all practical and appropriate efforts to help them communicate i.e. involve speech therapist, specialist in non - verbal communication, use simple muscle movements such as blinking to answer questions. CONT->";
                d = d + "\u2022If appropriate, the registered Lasting Power of Attorney(LPA) for Property and Affairs, Court Appointed Deputy or existing Enduring Power of Attorney must be consulted for matters relating to the finances of a person who lacks capacity for that decision. \r\n\r\n ";
                d = d + "\u2022If appropriate, the registered Lasting Power of Attorney(LPA) for Health & Welfare or Court Appointed Deputy must be consulted prior to any clinical intervention(except in a medical / surgical emergency) if a person lacks capacity for that decision unless the person has an existing advance decision or is detained under the Mental Health Act.\r\n\r\n";
                d = d + "\u2022An advanced decision enables someone over the age of 18 years of age, while still capable, to refuse specified treatment for a time in the future when they may lack capacity\r\n\r\n ";
                d = d+ "\u2022Advanced decisions may be verbal or written unless it relates to life sustaining treatment. An advanced decision to refuse treatment must state precisely what is being refused, may set out circumstances when refusal should apply and will only apply at a time when the person lacks capacity.\r\n\r\n ";

                l1.Text = a;
                l2.Text = b;
                l3.Text = c;
                l4.Text = d;
               

            }
            if (info == "Best Interests Decision")
            {

                a = "\u2022One of the key principals of the MCA is that any act done for or decision made on behalf of a person who lacks capacity must be made in their best interest. \r\n\r\n";
                a = a + "\u2022Working out what is someone's best interest may be difficult but should encourage the individual’s participation, identify all relevant circumstances, find out the persons view by consulting others, and avoid discrimination.\r\n\r\n ";
                a = a + "\u2022It may not be possible to wait and see if the person regains capacity in an emergency situation and therefore you must proceed with treatment without delay. Every decision is different when considering Best Interests but you should consider all relevant circumstances, encourage the person to participate, consider past and present wishes and consider the views of others that care for them.\r\n\r\n";
               a =a+ "\u2022If it is practical to do so, you should consult other people for their views about the persons best interest to see if they have any information about the persons wishes, feelings, beliefs, values. This may be anyone previously named by the individual, relatives or close friends, IMCA, someone with Lasting Power of Attorney or Court Appointed Deputy\r\n\r\n CONT->";
                b =  "\u2022Anyone assessing what is in someone’s best interest must not make unjustified assumptions about what is in their best interest simply on the basis of age, appearance, condition or any aspect of their behaviour as this could be considered discriminatory\r\n\r\n";
                b = b + "\u2022You should try and find out the persons past and present wishes that they may have expressed. This may be verbally, written, or through behaviour or habits.\r\n\r\n ";
                b = b + "\u2022You should consider religious, cultural, moral and political beliefs, behaviours and habits that may influence the decision.\r\n\r\n";
                b = b + "\u2022It is a principal in law and medical practice that people have the right to consent or refuse treatment. The courts have recognised that adults have the right to say in advance that they want to refuse treatment if they lose capacity in the future, even if it results in their death. Health care professionals must follow an advanced decision if it valid and applies to the particular circumstances\r\n\r\n ";
               b = b + "\u2022Consider if the individual is likely to regain capacity and if so when is it likely to return. This will depend on the cause of the lack of capacity. You may be able to postpone the decision until capacity returns.\r\n\r\n CONT->";
                c  = "\u2022Principal 5 of the MCA states that before and act is done or decision is made regard must be had to whether the proposed intervention for which it is needed can be as effectively achieved in a way that is less restrictive of the persons basic rights and freedoms. Where there is more than one option you should explore ways that would allow the most freedom. Any decision or action must still be in the person’s best interest. Sometimes it may be necessary to choose and option that is not the least restrictive option but is in the person’s best interest. In this case you may need to consider Deprivation of Liberty Safeguards(DOLS).\r\n\r\n";
                c = c + "\u2022Remember to document information used to support your decision and document which family, friends or carers that you have consulted.\r\n\r\n";

                l1.Text = a;
                l2.Text = b;
                l3.Text = c;
                

            }
            if (info == "IMCA Referrals")
            {
                s = "\u2022An Independent Mental Capacity Advocate (IMCA)must be instructed if a person of 16 years of age or over and a decision needs to be made about either a long term change in accommodation or serious medical treatment, where the person lacks capacity to make that decision and there is no one independent, such as family member or friend, to consult.\r\n\r\n";
                s = s + "\u2022IMCAs must also be instructed for DOLS application where there is no one independent, such as family member or friend, to consult.\r\n\r\n";
                s = s + "\u2022In addition, there is a duty to consider whether it would be of benefit for an IMCA to be instructed when there is a Safeguarding Adults from Abuse investigation and the person capacity to decide about the protective measures being proposed.This is the only issue that the person can have family or friends to consult and still have IMCA support.\r\n\r\n";

                l1.Text = s;

            }

            //  

            if (info == "DOLS Applications")
            {

                s = "\u2022The Deprivation of Liberty Safeguards (DOLS)provides legal protection for people who are, or may become, deprived of their liberty(as described in Article 5 of the European Convention on Human Rights ECHR) in a hospital or care home.\r\n";
                s = s + "\u2022DOLS legislation applies to people aged 18 years or over.\r\n";
                s = s + "DOLS does not apply to a person detained under the Mental Health Act\r\n";
                s = s + "\u2022The person’s capacity must be assessed in relation to the decision about accommodation in a care home or hospital for the purpose of providing care or treatment.\r\n\r\n";
                s = s + "\u2022The Best Interests Assessor(BIA) must satisfy themselves that person has a valid need to be detained in the proposed care setting, that it is in the persons best interests to be detained in that setting and determine whether any harm could arise if the DOLS is not authorised or if there are any less restrictive care options which could avoid DOLS.\r\n\r\n";
                s = s + "\u2022With regards specifically to the continuous supervision and control element of the acid test, please note the Law Society guidance as follows: ";
            
                    
                    l1.Text = s;
                LItalic.FormattedText = fs;

                
            }
          

            var S = new StackLayout
            {
                Spacing = 5,
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Children =
                        {            
                            home,
                   
                        }
            };


            

            var first_page = new ContentPage
            {
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {

                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                //        new Label { Text = info,
        //                TextColor = Color.FromHex("#953735"),
        //    XAlign = TextAlignment.Center,
        //        Font = Font.SystemFontOfSize(18)},
                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                 l1,LItalic
                },
                    }
                }
            };

            var second_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {

                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l2 ,

                    }
                    }
                }
            };
            var third_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l3,


                    }
                    }
                }
            };
            var forth_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                    new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l4,


                    }
                    }
                }
            };

            var fifth_page = new ContentPage
            {
                Padding = new Thickness(5, 5, 5, 5),
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children = {
                 new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(16)
                 },
                    l5 ,



                    }
                    }
                }
            };

            if (info == "Assessing Capacity Prompts")
            {
                Children.Add(first_page);
               Children.Add(second_page);
              Children.Add(third_page);
               Children.Add(forth_page);
          
            }
            if (info == "Best Interests Decision")
            {
                Children.Add(first_page);
                Children.Add(second_page);
                Children.Add(third_page);
              
               
            }

            if ((info == "IMCA Referrals") || (info == "DOLS Applications") || (info == "HSAB MCA Prompts")) 
            {
                Children.Add(first_page);
            }



        }
     

}
    
    
}





