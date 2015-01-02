using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void FindButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            //{
            //    //if (CheckBoxList1.Items[i].Selected)
                //{

                //    if (CheckBoxList1.Items[i].Text == "News")
                //    {
                        SRNewsFocus.ServicenewsfocusClient o = new SRNewsFocus.ServicenewsfocusClient();
                        string str = TextBoxName.Text;
                        string xml = o.Getxml(str);
                        // TextBox3.Text = xml;

                        string[] urls = o.Newsfocus(xml);
                        String str1 = null;
                        for (int i = 0; urls[i] != null; i++)
                        {
                            str1 += "--" + urls[i] + "\n";
                        }
                        LabelNewsWeather.Text += "The News about the region<br>";
                        LabelNewsWeather.Text += str1;
                    //}
                
               
                    //if (CheckBoxList1.Items[i].Text == "Weather")
                    //{
                        SRWeatherForecast.ServicePhase2MeghanaClient o1 = new SRWeatherForecast.ServicePhase2MeghanaClient();

                        String[] result = o1.GetWeatherForecast(TextBoxZip.Text);
                        String forecast = "For 5days: ";
                        for (int i = 0; i < 5; i++)
                            forecast += "\n" + result[i];

                        LabelNewsWeather.Text += "The Weather information is<br>";
                        LabelNewsWeather.Text += forecast + "<br>";
                    //}
                
                //}
            //}
        }

        /* HttpCookie myCookies = new HttpCookie("myCookieId");
         myCookies["WN"] = .ToString();
         myCookies.Expires = DateTime.Now.AddMonths(6);
         Response.Cookies.Add(myCookies);
         //Response.Redirect("Page2.aspx");*/

        protected void Button1_Click1(object sender, EventArgs e)
        {
            HttpCookie myCookies = new HttpCookie("myCookieId");
            myCookies["Latitude"] = TextBoxLatitude.Text;
            myCookies["Longitude"] = TextBoxLongitude.Text;
            myCookies["Name"] = TextBoxName.Text;
            myCookies["Zip"] = TextBoxZip.Text;
            myCookies.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(myCookies);
            Response.Redirect("http://localhost:54821/Page2");
        }

        protected void ButtonNews_Click(object sender, EventArgs e)
        {
        //{
        //    SRNewsFocus.ServicenewsfocusClient o = new SRNewsFocus.ServicenewsfocusClient();
        //    string str = TextBoxName.Text;
        //    string xml = o.Getxml(str);
        //    // TextBox3.Text = xml;

        //    string[] urls = o.Newsfocus(xml);
        //    String str1 = null;
        //    for (int i = 0; urls[i] != null; i++)
        //    {
        //        str1 += "--" + urls[i] + "\n";
        //    }
        //    LabelNewsWeather.Text += "The News about the region<br>";
        //    LabelNewsWeather.Text += str1;
            
            //}

             //HttpCookie myCookies = Request.Cookies["myCookieId"];
            Response.Redirect("http://localhost:8927/ServiceGasStation.svc/NearestGasStations?placename=" + TextBoxName.Text);
        }

        protected void ButtonWeather_Click(object sender, EventArgs e)
        {
            //SRWeatherForecast.ServicePhase2MeghanaClient o1 = new SRWeatherForecast.ServicePhase2MeghanaClient();

            //String[] result = o1.GetWeatherForecast(TextBoxZip.Text);
            //String forecast = "For 5days: ";
            //for (int i = 0; i < 5; i++)
            //    forecast += "\n" + result[i];

            //LabelNewsWeather.Text += "The Weather information is<br>";
            //LabelNewsWeather.Text += forecast + "<br>";
           // HttpCookie myCookies = Request.Cookies["myCookieId"];
            Response.Redirect("http://localhost:8472/ServiceCrimeRate.svc/CrimeRate?latitude=" + float.Parse(TextBoxLatitude.Text) + "&longitude=" + float.Parse(TextBoxLongitude.Text));

        }
       
    }
}