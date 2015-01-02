using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];


            LabelCredentials.Text += myCookies["Latitude"];
            LabelCredentials.Text += myCookies["Longitude"];
            LabelCredentials.Text += myCookies["Name"];
            LabelCredentials.Text += myCookies["Zip"];


            
            	
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            SRNewsFocus.ServicenewsfocusClient o = new SRNewsFocus.ServicenewsfocusClient();
            string str = myCookies["Name"];
            string xml = o.Getxml(str);
            // TextBox3.Text = xml;

            string[] urls = o.Newsfocus(xml);
            String str1 = null;
            for (int i = 0; urls[i] != null; i++)
            {
                str1 += "--" + urls[i] + "\n";
            }
            Label1.Text += "The News about the region<br>";
            Label1.Text += str1;
            Label1.Text += "<br>";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            SRWeatherForecast.ServicePhase2MeghanaClient o1 = new SRWeatherForecast.ServicePhase2MeghanaClient();

            String[] result = o1.GetWeatherForecast(myCookies["Zip"]);
            String forecast = "For 5days: ";
            for (int i = 0; i < 5; i++)
                forecast += "\n" + result[i];

            Label1.Text += "The Weather information is<br>";
            Label1.Text += forecast + "<br>";
            //HttpCookie myCookies = Request.Cookies["myCookieId"];

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SRSolarIntensity.ServiceSolarIntensityClient o = new SRSolarIntensity.ServiceSolarIntensityClient();
            float result = o.SolarIntensityService(40,-105);
            Label1.Text = "The Solar Intensity of the given place<br>";
            Label1.Text += Convert.ToString(result);
            Label1.Text += "<br>";
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("localhost:54821/Default.aspx");
        }

    }
}