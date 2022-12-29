namespace PassThePigs
{
    public class Scoreboard
    {
        // References:
        public int points;

        public Scoreboard()
        {
            this.points = 0;
        }

        public void RecordResult(int score)
        {
            switch (score)
            {
                case 2:
                this.points = this.points + 10;
                Console.WriteLine("You got Razorback and Trotter. Worth of 10 points.");
                break;

                case 3:
                this.points = this.points + 15;
                Console.WriteLine("You got Razorback and Snouter. Worth of 15 points.");
                break;

                case 4:
                this.points = this.points + 20;
                Console.WriteLine("You got Razorback and Leaning Jowler. Worth of 20 points.");
                break;

                case 5:
                this.points = this.points + 6;
                Console.WriteLine("You got Razorback and Sider. Worth of 6 points");
                break;

                case 6:
                this.points = this.points + 15;
                Console.WriteLine("You got Trotter and Snouter. Worth of 15 points.");
                break;

                case 7:
                this.points = this.points + 20;
                Console.WriteLine("You got Trotter and Leaning Jowler. Worth of 20 points");
                break;

                case 8:
                this.points = this.points + 6;
                Console.WriteLine("You got Trotter and Sider. Worth of 6 points");
                break;

                case 9:
                this.points = this.points + 25;
                Console.WriteLine("You got Snouter and Leaning Jowler. Worth of 25 points");
                break;

                case 10:
                this.points = this.points + 11;
                Console.WriteLine("You got Snouter and Sider. Worth of 11 points");
                break;

                case 11:
                this.points = this.points + 16;
                Console.WriteLine("You got Leaning Jowler and Sider. Worth of 16 points");
                break;

                case 12:
                this.points = this.points + 20;
                Console.WriteLine("You got Double Razorback. Worth of 20 points");
                break;

                case 13:
                this.points = this.points + 20;
                Console.WriteLine("You got Double Troutter. Worth of 20 points");
                break;

                case 14:
                this.points = this.points + 40;
                Console.WriteLine("You got Double Snouter. Worth of 40 points");
                break;

                case 15:
                this.points = this.points + 60;
                Console.WriteLine("Double Leaning Jowler. Worth of 60 points");
                break;

                case 16:
                // How to make this? Gotta return back to points player had at start of turn.
                Console.WriteLine("You got Pig out! You get 0 points from this round and you have to pass turn to next player!");
                break;

                case 18:
                this.points = 0;
                Console.WriteLine("You got Makin' Bacon. Your total score from the game is wiped out! Pass turn to next player!");
                break;
            }
        }

        public int CountScore()
        {
            int endScore = 0;
            endScore = endScore + this.points;

            return endScore;
        }
    }
}