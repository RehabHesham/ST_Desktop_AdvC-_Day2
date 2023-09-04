using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location location { get; set; } = new Location();


        //public void MoveTo(Location ballloc)
        //{
        // //   Console.WriteLine("Player is moving");
        //    Console.WriteLine($"player is moving from ({location.x},{location.y}) to ({ballloc.x},{ballloc.y})");
        //   location = ballloc;
        //}

        public void MoveTo(Object sender, EventArgs e)
        {
            Football ball = (Football)sender;
            //   Console.WriteLine("Player is moving");
            Console.WriteLine($"player is moving from ({location.x},{location.y}) to ({ball.Location.x},{ball.Location.y})");
            location = ball.Location;
        }

        public override string ToString()
        {
            return $"player {Name} is at ({location.x},{location.y})";
        }
    }

}
