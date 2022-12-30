namespace PassThePigs
{
    public class Player
    {
        // References:
        public string name;
        public Scoreboard points;
        public int score;

        public Player(string name)
        {
            this.name = name;
            this.points = new Scoreboard();
        }

        public void UseTurn()
        {
            while (true)
            {
            // Makes a new pig
            PigJar pig = new PigJar();
            // Score is what Throw value is
            score = pig.TossingPigs();
            // Records your Throw() to player points and does what RecordResult switch case does
            this.points.RecordResult(score);
            // Tells player how many points at the moment
            Console.WriteLine(this.name + " has now " + this.points.CountScore() + " points.");

            if (!this.points.PointsOver100())
                    {
                        Console.WriteLine("Player " + this.name + " got over 100 points and won!");
                        Environment.Exit(0);
                    } 

            Console.WriteLine("Do you want to throw again? (Yes / No)");
                if (Console.ReadLine() == "No")
                {
                    break;
                }
            }
        }
    }
}