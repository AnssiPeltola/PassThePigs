namespace PassThePigs
{
    public class PigJar
    {
        // References:
        private Pigs[] pigs;
        int[] score = new int[100];
        int pigsValue = 0;
        

        public PigJar()
        {
            // Making pigs using class Pigs constructor
            pigs = new Pigs[2];
            for (int i = 0; i < 2; i++)
            {
                pigs[i] = new Pigs();
            }
        }

        public int[] TossingPigs()
        {
            

            while (true)
            {
                foreach (Pigs pig in pigs)
                {
                   pig.Throw();
                }

                    Console.WriteLine("Which position pig landed:");

                    for (int i = 1; i <= 2; i++)
                    {
                        Console.WriteLine("Pig " + i + ": " + pigs[i-1].value);
                       // pigsValue = pigsValue + pigs[i].value;
                    }

                    Console.WriteLine("Want to throw again? (y/n)");

                    string input = Console.ReadLine();
                    if (input == "n")
                    {
                        break;
                    }

                        // Store score
                        for (int i = 0; i < 2; i++)
                        {
                            score[i] = pigs[i].value;
                        }

                    return score;
            }

            return score;
        }
    }
}
