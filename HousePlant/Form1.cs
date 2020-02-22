using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousePlant
{
    public partial class Form1 : Form
    {
        readonly int MinTemp = 50; //Global variables, available to all methods
        readonly int MaxTemp = 90; //Convention is to use UppercaseCamelCase names
        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
            this.trkTemp.Minimum = MinTemp;
            this.trkTemp.Maximum = MaxTemp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            //Use format string, the # symbol is replace by the number in tryTemp.Value
            //Pressing Alt + 0176 on your number pad types a ° symbol
            lblTemp.Text = trkTemp.Value.ToString("# ºF");
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southFacingWindowAvailable = chkSouthFacing.Checked;
            if (homeTemp == MinTemp)
            {
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
            }
            if (homeTemp == MaxTemp)
            {
                //Can you show a messege with caption "Information" and
                //and text "Your home may be too warm for most plants"
                //Use the named parameters for the text and caption parameters
                MessageBox.Show(text: "Your home may be too hot for most houseplants", caption: "Information");
            }
            //Call our method, use return value
            string suggestedPlant = GenerateSuggestion(homeTemp, southFacingWindowAvailable);
            lblSuggestion.Text = suggestedPlant;
        }
        private string GenerateSuggestion(int temp, bool southFacing)
        {
            if (southFacing)
            { 
                if (temp > 65)
                {
                    return "Peace Lily"; //Warm with light
                }
                else
                {
                    return "Spider Plant"; //cool with light
                }
            }
            else
            {
                if (temp > 65)
                {
                    return "Dragon Tree"; //Warm with low light
                }
                else
                {
                    return "Ivy"; //Cool with low light
                }
            }
        }

        private void lblSuggestion_Click(object sender, EventArgs e)
        {

        }

        private void InkHousePlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                ShowWebPage(); //plantName is optional
            }
            else
            {
                ShowWebPage(lblSuggestion.Text);
            }
        }
        private void ShowWebPage(string plantName = null) //Create new method
        {
            string url = "https://www.houseplant411.com/";
            if (plantName != null)
            {
                //Link to a specific plant should be in the form "https://www.houseplant411.com/houseplant?hpg=ivy"
                url = url + "houseplant?hpq=" + plantName;
            }    
            System.Diagnostics.Process.Start(url); //Launch web browser, navigate to URL given
            
        }
    }
}

