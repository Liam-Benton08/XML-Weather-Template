using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        //Creates all my strings in this screen
        public static string location;
        public string city = "Stratford";
        public string country = "CA";
        public static string error = "";
        string savedLoco = "";

        public SearchScreen()
        {
            InitializeComponent();

            //Sets the current city when the screen changes
            cityOutput.Text = Form1.location;
        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            //Sets these variables to blank
            error = "";
            savedLoco = "";

            //Sets saved location to location
            savedLoco += location;

            //Takes the input and changes to variables to the inputs
            city = cityInput.Text;
            country = countryInput.Text;

            //if they dont fill it out properly
            if (country == "" || city == "")
            {
                //changes to make it error
                city = "dajsda";
                country = "sdad";
            }

            //sets location to the input
            location = city + "," + country;
            Form1.location = location;

            //Runs the new link and takes new values
            Form1.days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();

            //This will be blank if it works
            if(error == "")
            {
                error = "City Changed";
                cityOutput.Text = location;
            }
            //This is if it errors in form1
            else
            {
                location = "";
                location += savedLoco;
                Form1.location = location;
            }


            errorMessageLabel.Text = error;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            //Only lets me change screens if no errors
            if (error == "" || error == "City Changed")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
        }
    }
}
