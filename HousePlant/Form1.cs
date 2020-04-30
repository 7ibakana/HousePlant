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
        bool ShownMinWarning = false;
        bool ShownMaxWarning = false;
        HousePlantInfo plantInfo = new HousePlantInfo();
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
            string suggestedPlant = plantInfo.GenerateSuggestion(homeTemp, southFacingWindowAvailable);
            lblSuggestion.Text = suggestedPlant;
        }

        private void lblSuggestion_Click(object sender, EventArgs e)
        {

        }

        private void InkHousePlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                plantInfo.ShowWebPage(); //plantName is optional
            }
            else
            {
                plantInfo.ShowWebPage(lblSuggestion.Text);
            }
        }

    }
}

