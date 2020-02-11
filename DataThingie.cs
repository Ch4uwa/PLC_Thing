using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataThingie
    {
        private int temp_val() 
        {
            // Create a random integer to simulate changing temperature
            var rnd = new Random();
            var rnd_temperature = rnd.Next(19, 34);

            return rnd_temperature;
        }

        // Simulating bool states
    }
}
