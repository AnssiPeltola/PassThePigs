namespace PassThePigs
{
    public class PigJar
    {
        // References:
        private Pigs pigs;

        public PigJar()
        {
            // Making pigs using class Pigs constructor
            pigs = new Pigs();
        }

        // Tosses pig(s) and returns its score
        public int TossingPigs()
        {
            while (true)
            {
                int score = 0;

                score = pigs.Throw();

                return score;
            }
        }
    }
}
