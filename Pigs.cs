namespace PassThePigs
{
    public class Pigs
    {
        // References:
        public int value { get; set; }

        public Pigs()
        {
        
        }

        public void Throw()
        {
            Random draw = new Random();
            value = draw.Next(1, 7);
        }
    }
}