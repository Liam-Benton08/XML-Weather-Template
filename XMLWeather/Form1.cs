using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

//Liam Benton
//This is a weather app created to give you the weather from anywhere in the world
namespace XMLWeather
{

    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static int weatherValue;
        public static string location;
        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);

            
        }

        public static void ExtractForecast()
        {
            try
            {
                if (SearchScreen.location == null)
                {
                    //if it is empty then the location is Stratford 
                    location = "Stratford,CA";
                }
                else
                {
                    //changes location to searchscreen location
                    location = SearchScreen.location;
                }

                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

                while (reader.Read())
                {
                    // create a day object
                    Day d = new Day();

                    //finds the time element and get the day attribute
                    reader.ReadToFollowing("time");
                    d.date = reader.GetAttribute("day");

                    reader.ReadToFollowing("symbol");
                    d.number = Convert.ToInt16(reader.GetAttribute("number"));

                    //find the temperature element and get the min and max elements
                    reader.ReadToFollowing("temperature");
                    d.tempLow = reader.GetAttribute("min");
                    d.tempHigh = reader.GetAttribute("max");

                    //add day to list of days
                    days.Add(d);
                }
            }
            catch
            {
                SearchScreen.error = "Invalid city or country";
            }
        }

        public static void ExtractCurrent()
        {
            try
            {
                if (SearchScreen.location == null)
                {
                    //if it is empty then the location is Stratford 
                    location = "Stratford,CA";
                }
                else
                {
                    //changes the location to searchscreen
                    location = SearchScreen.location;
                }
                // current info is not included in forecast file so we need to use this file to get it
                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

                //Finds the values for today and then sends them to days values
                days[0].location = location;

                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");

                reader.ReadToFollowing("weather");
                days[0].number = Convert.ToInt16(reader.GetAttribute("number"));
                days[0].symbolName = reader.GetAttribute("value");
            }
            catch
            {
                //changes the error label on the other screen if search is wrong
                SearchScreen.error = "Invalid city or country";
            }
        }
    }
}
