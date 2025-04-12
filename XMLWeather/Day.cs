using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        //creates all the strings
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, symbolNumber, symbolName, precipitation, visibility, country;

        //creates int
        public int number;

        //creates image
        public Image weatherImage;

        public Day()
        {
            //sets it all to nothing
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = symbolNumber = symbolName = precipitation = country = visibility = "";

            number = 0;

            weatherImage = null;
        }

        public static void ImageFinder(Day d)
        {
            //checks weather number and changes image
            if (d.number >= 200 && d.number < 300)
            {
                d.weatherImage = Properties.Resources.thunderStorm;
            }
            else if (d.number >= 300 && d.number < 400)
            {
                d.weatherImage = Properties.Resources.rainy;
            }
            else if (d.number >= 500 && d.number < 600)
            {
                d.weatherImage = Properties.Resources.rainy;
            }
            else if (d.number >= 600 && d.number < 700)
            {
                d.weatherImage = Properties.Resources.snowy;
            }
            else if (d.number >= 700 && d.number < 800)
            {
                d.weatherImage = Properties.Resources.mist;
            }
            else if (d.number == 800)
            {
                d.weatherImage = Properties.Resources.sunny;
            }
            else if (d.number >= 801)
            {
                d.weatherImage = Properties.Resources.partialClouds;
            }
        }

    }
}
