namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intializing game");

            // publisher
            Football ball = new Football(); 


            // subscripers
            Player player = new Player();
            Referee referee = new Referee();


            // subscription
            ball.OnMove += player.MoveTo;
            ball.OnMove += referee.Observe;


            // firing event
            ball.Location = new Location() { x = 10, y = 10 };


            ball.Location = new Location() { x = 20, y = 10 };


        }
    }
}