namespace FootballGame
{
    internal class Football
    {
        public int Id { get; set; }

        Location location;
        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;

                if (OnMove != null)
                    // OnMove(value);  // firing event
                    OnMove(this, null);
            }
        }

       // public event Action<Location> OnMove;
        public event EventHandler OnMove;


        public override string ToString()
        {
            return $"ball number {Id} is at ({location.x},{location.y})";
        }
    }
}
