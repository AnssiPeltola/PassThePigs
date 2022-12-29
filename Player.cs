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
            // Makes a new pig
            PigJar pig = new PigJar();
            // Score is what Throw value is
            score = pig.TossingPigs();
            // Records your Throw() to player points and does what RecordResult switch case does
            this.points.RecordResult(score);
            
        }
    }
}