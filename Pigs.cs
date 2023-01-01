namespace PassThePigs
{
    public class Pigs
    {
        // References:
        public int value { get; set; }

        public Pigs()
        {
        
        }

        // Throws (pig) which gives a int value between 1 and 160. Returns its value.
        public int Throw()
        {
            Random draw = new Random();
            value = draw.Next(1, 161);
            return value;
        }
    }
}