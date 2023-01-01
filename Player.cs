namespace PassThePigs
{
    public class Player
    {
        // References:
        public string name;
        public Scoreboard points;
        public int score;
        public int scoreBeforeThrow;

        public Player(string name)
        {
            this.name = name;
            this.points = new Scoreboard();
            this.scoreBeforeThrow = this.points.points;
        }

        public void UseTurn()
        {
            ScoreBeforeThrow();

            while (true)
            {
            // Makes a new pig
            PigJar pig = new PigJar();
            // Score is what Throw value is
            score = pig.TossingPigs();
            // Records your Throw() to player points and does what RecordResult switch case does
            this.points.RecordResult(score);

            // Checks if player gets Pig out. Player get 0 points from this round. Breaks loop and passes turn to next player
            if (score >= 141 && score <= 155)
            {
                this.points.points = scoreBeforeThrow;
                Console.WriteLine(this.name + " has now " + this.points.CountScore() + " points.");
                break;
            }

            // Checks if player gets Makin' Bacon. Resets points back to 0 and passes turn to next player.
            if (score >= 156 && score <= 160)
            {
                Console.WriteLine(this.name + " has now " + this.points.CountScore() + " points.");
                break;
            }

            // Tells player how many points at the moment
            Console.WriteLine(this.name + " has now " + this.points.CountScore() + " points.");

            // Checks if players points is 100 or higher after recording score.
            if (!this.points.PointsOver100())
                    {
                        Console.WriteLine("Player " + this.name + " got over 100 points and won!");
                        Environment.Exit(0);
                    } 

            // Asks if player wants to continue or pass turn to next player.
            Console.WriteLine("Do you want to throw again? (Yes / No)");
                if (Console.ReadLine() == "No")
                {
                    break;
                }

                Console.WriteLine("");
            }
        }

        // Method to store points where player started current turn.
        public int ScoreBeforeThrow()
        {
            this.scoreBeforeThrow = this.points.points;
            return scoreBeforeThrow;
        }
    }
}