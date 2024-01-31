namespace stopwatch
{

    class Program
    {
        static void Main(String[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while(currentTime != time)
            {   
                currentTime++;
                Console.WriteLine(currentTime);
            }
        }

    }
}
