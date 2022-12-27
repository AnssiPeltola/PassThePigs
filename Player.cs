namespace PassThePigs
{
    public class Player
    {
        // References:
        public string name;
        private Scoreboard points;

        public Player(string name)
        {
            this.name = name;
            this.points = new Scoreboard();
        }

        public void UseTurn()
        {
            PigJar setOfPigs = new PigJar();
            int[] score = setOfPigs.TossingPigs();
        }
        /* public bool Less100Points()
        {
            if (this.points.scores < 100)
            {
                return true;
            }
            else 
            {
                return false;
            }
        } */
    }
}