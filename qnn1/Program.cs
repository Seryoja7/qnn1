namespace qnn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int qanak = 0;
            int number2 = number1;
            int number3 = number1;
            while(number1 >= 1)
            {
                qanak++;
                number1 /= 10;
            }
            int[] numbers = new int[qanak];
            for(int i = 0;i < qanak; i++)
            {
                int tvanshan = number2 % 10;
                int tvanshan2 = tvanshan;
                for(int j = 0;j < qanak - 1; j++)
                {
                    tvanshan *= tvanshan2;
                }
                numbers[i] = tvanshan;
                number2 /= 10;
            }
            int gumar = 0;
            for(int i = 0;i < qanak; i++)
            {
                gumar += numbers[i];
            }
            if(number3 == gumar)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}