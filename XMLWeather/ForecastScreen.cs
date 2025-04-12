using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public Image forecastImage;
        public int forecastNum;

        Pen areaBrush = new Pen(Color.Black);

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            LabelChange();

            Refresh();
        }

        private void LabelChange()
        {
            //Displays all the information for each day to the screen
            date1.Text = $"{(Convert.ToDateTime(Form1.days[1].date).DayOfWeek)}";
            min1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempLow), 0))}°";
            max1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempHigh), 0))}°";

            date2.Text = $"{Convert.ToDateTime(Form1.days[2].date).DayOfWeek}";
            min2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempLow), 0))}°";
            max2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempHigh), 0))}°";

            date3.Text = $"{Convert.ToDateTime(Form1.days[3].date).DayOfWeek}";
            min3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempLow), 0))}°";
            max3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempHigh), 0))}°";

            date4.Text = $"{Convert.ToDateTime(Form1.days[4].date).DayOfWeek}";
            min4.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[4].tempLow), 0))}°";
            max4.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[4].tempHigh), 0))}°";

            //sets a counter
            int counter = 1;

            //gets the photo from each day
            while (counter < 5)
            {
                Day.ImageFinder(Form1.days[counter]);
                counter++;
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //Changes to the search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }

        private void ForecastScreen_Paint(object sender, PaintEventArgs e)
        {
            //sets changeable variables
            int y = 20;
            int counter = 1;

            //Paints each day of images
            while (counter < 5)
            {
                e.Graphics.DrawImage(Form1.days[counter].weatherImage, 10, y, 100, 100);
                y += 80;
                counter++;
            }
        }

        private void currentLabel_Click(object sender, EventArgs e)
        {
            //Changes to the currentScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
