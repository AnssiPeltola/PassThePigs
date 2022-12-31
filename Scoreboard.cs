namespace PassThePigs
{
    public class Scoreboard
    {
        // References:
        public int points;
        // public List<int> turnPoints; // Mabey use this to gather this turn points because pig out wipes only current TURN points.

        public Scoreboard()
        {
            this.points = 0;
        }

        // Scoreboard // Need to fix that has better chance to low points and harder to get good points <- Dice has to be bigger and cases between bigger numbers.
        public void RecordResult(int score)
        {
            switch (score)
            {
                case 1:
                this.points = this.points + 10;
                Console.WriteLine("You got Razorback and Trotter. Worth of 10 points.");
                break;

                case 2:
                this.points = this.points + 15;
                Console.WriteLine("You got Razorback and Snouter. Worth of 15 points.");
                break;

                case 3:
                this.points = this.points + 20;
                Console.WriteLine("You got Razorback and Leaning Jowler. Worth of 20 points.");
                break;

                case 4:
                this.points = this.points + 6;
                Console.WriteLine("You got Razorback and Sider. Worth of 6 points");
                break;

                case 5:
                this.points = this.points + 15;
                Console.WriteLine("You got Trotter and Snouter. Worth of 15 points.");
                break;

                case 6:
                this.points = this.points + 20;
                Console.WriteLine("You got Trotter and Leaning Jowler. Worth of 20 points");
                break;

                case 7:
                this.points = this.points + 6;
                Console.WriteLine("You got Trotter and Sider. Worth of 6 points");
                break;

                case 8:
                this.points = this.points + 25;
                Console.WriteLine("You got Snouter and Leaning Jowler. Worth of 25 points");
                break;

                case 9:
                this.points = this.points + 11;
                Console.WriteLine("You got Snouter and Sider. Worth of 11 points");
                break;

                case 10:
                this.points = this.points + 16;
                Console.WriteLine("You got Leaning Jowler and Sider. Worth of 16 points");
                break;

                case 11:
                this.points = this.points + 20;
                Console.WriteLine("You got Double Razorback. Worth of 20 points");
                break;

                case 12:
                this.points = this.points + 20;
                Console.WriteLine("You got Double Troutter. Worth of 20 points");
                break;

                case 13:
                this.points = this.points + 40;
                Console.WriteLine("You got Double Snouter. Worth of 40 points");
                break;

                case 14:
                this.points = this.points + 60;
                Console.WriteLine("Double Leaning Jowler. Worth of 60 points");
                break;

                // Needs fix to reset score back where turn started!
                case 15:
                Console.WriteLine("You got Pig out! You get 0 points from this round and you have to pass turn to next player!");
                break;

                case 16:
                this.points = 0;
                Console.WriteLine("You got Makin' Bacon. Your total score from the game is wiped out! Pass turn to next player!");
                break;
            }
        }

        // Adds points to his totalscore // Needs fix because of pig out only resets turn now
        public int CountScore()
        {
            int endScore = 0;
            endScore = endScore + this.points;

            return endScore;
        }

        // Checks if player has 100 or over points
        public bool PointsOver100()
        {
            if (this.points <= 100)
            {
                return true;
            }

            return false;
        }
    }
}