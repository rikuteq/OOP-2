namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1: Creating Variables

            //Low Number
            Console.WriteLine("Please enter a low number: ");
            string userInput = Console.ReadLine();
            int lowwNum;
            //Convert string to integer
            bool b = int.TryParse(userInput, out lowwNum);

            //High Number
            Console.WriteLine("Please enter a high number: ");
            string userInput2 = Console.ReadLine();
            int highNum;
            //Covert string to integer
            bool b2 = int.TryParse(userInput2, out highNum);

            //Calculate and print difference between low and high num
            Console.WriteLine($"\nDifference of {highNum - lowwNum}");

            //TASK 2: Looping and Input Validation

            int lowNum = GetLowNum();
            int higherNum = GetHigherNum(lowNum);

            //TASK 3: Using Arrays and File I/O

            ArrayNumbers(lowNum, higherNum);

            //Additional Tasks

            ListNumbers(lowNum, higherNum);
            PrimeNum();
        }
        //Loops (Methods for Task 2)

        public static int GetLowNum()
        {
            int userNumInt;
            while (true)
            {
                Console.WriteLine("Enter a POSITIVE low number: ");
                string userNum = Console.ReadLine();

                bool t = int.TryParse(userNum, out userNumInt);

                if (t && userNumInt > 0)
                {
                    return userNumInt;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a POSITIVE low number.");
                }
            }
        }
        public static int GetHigherNum(int lowNum)
        {
            int higherNumInt;
            while (true)
            {
                Console.WriteLine("Enter a higher number than your last: ");
                string higherNum = Console.ReadLine();

                bool t = int.TryParse(higherNum, out higherNumInt);

                if (t && higherNumInt > lowNum)
                {
                    return higherNumInt;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number higher than your last.");
                }

            }
        }
        //Method for Task 3
        public static void ArrayNumbers(int lowNum, int higherNum)
        {
            int[] arr = new int[(higherNum - lowNum)];
            int c = 0;

            for (int i = lowNum + 1; i < higherNum; i += 1)
            {
                arr[c] = i;
                c += 1;
            }
            using (StreamWriter sw = new("C:\\Users\\elias\\Projects\\Lab0\\Lab0\\numbers.txt"))
            {
                for (int i = arr.Length - 1; i >= 0; i -= 1)
                {
                    sw.WriteLine(arr[i]);
                }
            }
            //(Additional Tasks) Read the numbers back from the file and print out the sum of the numbers
            string[] arrFile = File.ReadAllLines("C:\\Users\\elias\\Projects\\Lab0\\Lab0\\numbers.txt");
            int count = 0;
            foreach (string line in arrFile)
            {
                bool t = int.TryParse(line, out int number);
                count += number;
            }
            Console.WriteLine($"{count} is the total of the numbers between {lowNum} and {higherNum}");
        }

        //Methods for the other Additional Tasks
        public static void ListNumbers(int lowNum, int higherNum)
        {
            List<double> NumbersList = new List<double>();

            for(int i = lowNum + 1; i < higherNum; i += 1)
            {
                NumbersList.Add(i);                
            }
            
            foreach(double value in NumbersList)
            {
                Console.WriteLine(value);
            }                                                                      
        }
        public static void PrimeNum()
        {
            Console.WriteLine("Enter any number: ");
            string userInput = Console.ReadLine();

            bool t = int.TryParse(userInput, out int number);
            for(int i = 2; i < number; i += 1)
            {
                if(number % i != 0)
                {                   
                    if (i == number - 1)
                    {
                        Console.WriteLine($"{number} is a prime number!");
                    }
                }
                else
                {
                    Console.WriteLine($"{number} is divisible by {i}, therefore its NOT a prime number");
                    return;
                }
            }                        
        }
    }
}


