using System;

namespace c_sharp_course
{

    //hi this is some practice for @ashkanRmk c# course...  q:-)
    class Program
    {
        static void Main(string[] args)
        {
            Creat__Pyramid_By_Getting_Lines();
        }
        //creat pyramid like New_Physa() but this can get the triangle height
        private static void New_PhysaV2()
        {
            Console.WriteLine("please enter the A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter The B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double sum = Math.Pow(A, 2) + Math.Pow(B, 2);
            double hypotenuse = Math.Sqrt(sum);
            Console.WriteLine("enter your lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nTHIS IS Hypotenuse:{hypotenuse}");

            int spaces = A.ToString().Length + 3;
            int middle = lines / 2;

            Console.Write("\n");
            for (int i = 1; i <= lines; i++)
            {
                if (i == middle)
                {
                    Console.Write($"A: {A} ");
                }
                else
                {
                    for (int j = 0; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                if (i == middle)
                {
                    Console.Write($"  Hypotenuse :({hypotenuse})");

                }
                Console.Write("\n");

            }
            Console.Write($"       B: {B}   ");
        }

        //creat a pyramid who keep its shape by any number
        private static void New_physa()
        {
            Console.WriteLine("please enter the A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter The B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double sum = Math.Pow(A, 2) + Math.Pow(B, 2);
            double hypotenuse = Math.Sqrt(sum);

            Console.WriteLine($"\nTHIS IS Hypotenuse:{hypotenuse}");
            int lines = 6;
            int spaces = A.ToString().Length + 3;

            Console.Write("\n");
            for (int i = 1; i <= lines; i++)
            {
                if (i == 3)
                {
                    Console.Write($"A: {A} ***  Hypotenuse :({hypotenuse})\n");
                }
                else
                {
                    for (int j = 0; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            Console.Write($"       B: {B}   ");
        }
        //creat pyramid by getting line
        private static void Creat__Pyramid_By_Getting_Lines()
        {
            Console.WriteLine("please choose your lines");
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                Console.Write(i + ": ");
                if (i % 2 != 0)
                {
                    int space = (lines - i) / 2;
                    int moreSpace = lines.ToString().Length - i.ToString().Length;

                    for (int j = 0; j <= space + moreSpace; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    for (int l = 0; l <= space; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                else { Console.Write("\n"); }
            }

        }

        //Guess the right number in Ashkan way
        private static void GuessTheRightNumberInAshkanWay()
        {
            Random randomNumber = new Random();
            int min = 0;
            int max = 100;
            bool playAgain = true;
            int round = 0;
            do
            {
                int right_number = randomNumber.Next(min, max + 1);
                Console.WriteLine("choose a number 0-100");
                int player_guess = 0;

                while (player_guess != right_number)
                {
                    player_guess = Convert.ToInt32(Console.ReadLine());

                    if (player_guess > right_number)
                    {
                        Console.WriteLine("your number is too high");
                    }
                    else if (player_guess < right_number)
                    {
                        Console.WriteLine("your number is too low");
                    }
                    ++round;
                }
                Console.WriteLine($"you found the right answere in {round} Round..would you like to play again?(Y/N)");

                playAgain = Console.ReadLine().ToUpper() == "Y";
                Console.Clear();





            }
            while (playAgain);
            Console.WriteLine("thanks for Playing");
        }

        //Guess the right number game
        private static void GuessTheRightNumber()
        {
            bool want_To_Play = true;

            do
            {
                Random random = new Random();
                int choosedNumber = random.Next(0, 101);

                bool isAnswered = false;
                int test_count = 0;

                do
                {
                    Console.WriteLine("choose a number between 0 and 100");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    test_count++;

                    if (userNumber > choosedNumber)
                    {
                        Console.WriteLine($" ({userNumber}) is too Hight!!!");

                    }
                    else if (userNumber < choosedNumber)
                    {
                        Console.WriteLine($"({userNumber}) is too low!!!");

                    }
                    else
                    {
                        Console.WriteLine($"you found the right number in ({test_count}) try ,it was ({userNumber}) ;)");
                        isAnswered = true;

                    }

                }
                while (isAnswered == false);

                Console.WriteLine("would you like to Play again?");
                string want_to_play_answer = Console.ReadLine();
                want_To_Play = want_to_play_answer == "yes";
                if (want_To_Play == true)
                {
                    Console.Clear();
                }

            } while (want_To_Play);
            Console.WriteLine("thanks for playing");
        }

        //TV channel method
        private static void TV_Channel()
        {
            int channelNum = 1;
            bool likeItBool = false;

            do
            {

                Console.WriteLine("Are you like " + channelNum + " TV Channel?");
                Console.WriteLine("please answer with Yes or No");
                string likeItstring = Console.ReadLine();
                likeItstring.ToLower();
                if (likeItstring == "yes")
                {
                    likeItBool = true;
                }
                else { channelNum++; }

            } while (likeItBool == false);
            Console.WriteLine($"{channelNum} is your favorite Channel");
        }

        //a method for calculating a triangle hypotenuse  
        private static void WHO_Adult_BMI_Cal()
        {
            Console.WriteLine("what is your weight?");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is your height as METER?");
            var height = Convert.ToDouble(Console.ReadLine());
            var BMI = weight / (Math.Pow(height, 2));
            Console.WriteLine("your BMI is : " + BMI);


            if (BMI < 16)
            {
                Console.WriteLine("Severely Under Weight!!!");

            }
            else if (BMI >= 16 && BMI <= 18.4)
            {
                Console.WriteLine("Under Wegiht!!");

            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("*NORMAL*");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("OverWeight!");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine("Moderately Obese!!");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine("Severely Obese!!!");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Morbidly Obese!!!");
            }
        }

        // cal hypotenuse of a triangle by using Physagoras formul 
        private static void Physagoras()
        {
            Console.WriteLine("please enter the A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter The B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double sum = Math.Pow(A, 2) + Math.Pow(B, 2);
            double hypotenuse = Math.Sqrt(sum);

            Console.WriteLine($"\nTHIS IS Hypotenuse:{hypotenuse}");

            Console.WriteLine($"\n                      *\n\n                      *   *\n\n                      *       *\n           A: {A}                   Hypotenuse :({hypotenuse})\n                      *           *\n\n                      *               *\n\n                      *   *   *   *   *   *");
            Console.Write($"                            B: {B}   ");

        }

        //practice for convert numbers
        private static void AB()
        {
            System.Console.WriteLine("please enter a number as A:");
            double A = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("\nplease enter a number as B:");
            double B = Convert.ToDouble(Console.ReadLine());

            double sourat = Math.Pow(A, 3);
            double makhraj = Math.Pow(A, 2) + 2 * (Math.Pow(B, 2)) + 5;

            double result = sourat / makhraj;

            System.Console.WriteLine($"\nthe result is {result}");
            System.Console.WriteLine(string.Format("{0:0.00}", result));
        }

        //Draw with C#
        private static void Pyramid_Method()
        {
            Console.Write("\n   *\n  ***\n *****\n*******");
            Console.WriteLine("\n------------");
            Console.Write("*\n**\n* *\n*  *\n*   *\n*    *\n*******");
            Console.WriteLine("\n------------");
            Console.Write("   *\n  * *\n *   *\n*******");
            Console.WriteLine("\n------------");
            Console.Write("   *\n  * *\n *   *\n*     *\n *   *\n  * *\n   *");
        }

        //practice for input
        public static void GetNameAndAge()
        {
            Console.WriteLine("please enter your name below :");
            string name = Console.ReadLine();

            Console.WriteLine("\nplease enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"your name is:{name} and you are {age} years old");

        }
    }
}
