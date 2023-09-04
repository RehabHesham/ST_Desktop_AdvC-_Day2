using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    internal class Referee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Location location { get; set; } = new Location();


        public void Observe(object sender, EventArgs e)
        {
            //var canConvert =  sender is Football;
            // if (canConvert)
            // {
            //     Football football = (Football)sender;
            //     Console.WriteLine($"Referee is observing ball at ({football.Location.x},{football.Location.y})");
            // }

            Football football = sender as Football;
            if (football != null)
            {
                Console.WriteLine($"Referee is observing ball at ({football.Location.x},{football.Location.y})");
            }
        }

        public override string ToString()
        {
            return $"referee {Name} is at ({location.x},{location.y})";
        }
    }
}
