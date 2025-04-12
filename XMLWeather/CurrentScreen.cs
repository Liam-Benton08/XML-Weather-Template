using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public Image weatherImage;
        public int weatherNum;
        List<Day> days = new List<Day>();

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //Calls the Image finder method to see what image needs to be used
            Day.ImageFinder(Form1.days[0]);

            //displays all the current information on the screen
            cityOutput.Text = $"{Form1.location}";
            minOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].tempLow), 0))}°";
            maxOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].tempHigh), 0))}°";
            currentOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].currentTemp), 0))}°";
            symbolNameOutput.Text = Form1.days[0].symbolName;
            dateLabel.Text = $"{Convert.ToString(DateTime.Now.DayOfWeek)}, {Convert.ToDateTime(DateTime.Now.Date).ToString("MMMM dd")}";

            //Only Calls the Refresh once for the image
            Refresh();

        }
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //Changes to the forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
        private void searchLabel_Click(object sender, EventArgs e)
        {
            //Changes to the search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draws whatever image the weather is
            e.Graphics.DrawImage(Form1.days[0].weatherImage, 50, 60, 150, 150);
        }
    }
}
