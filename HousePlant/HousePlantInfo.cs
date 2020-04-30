using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePlant
{
    class HousePlantInfo
    {
        public void ShowWebPage(string plantName = null) //Create new method
        {
            string url = "https://www.houseplant411.com/";
            if (plantName != null)
            {
                //Link to a specific plant should be in the form "https://www.houseplant411.com/houseplant?hpg=ivy"
                url = url + "houseplant?hpq=" + plantName;
            }
            System.Diagnostics.Process.Start(url); //Launch web browser, navigate to URL given

        }
        public string GenerateSuggestion(int temp, bool southFacing)
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
    }
}
