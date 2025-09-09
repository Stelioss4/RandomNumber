namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                const int LOW_NUMBER = 1;
                const int HIGH_NUMBER = 100;
                const int MAX_TRIES = 10;
                const int SO_CLOSE_MAX = 5;
                const int SO_CLOSE_LOW = 1;



                var Result = 0;
                int yourNumber = 0;
                int randomNumber = 0;
                int tries = 0;
                int soClosehigh = 0;

                Console.WriteLine("Hello and welcome to.. GUESS THE NUMBER!!");


                while (true)
                {

                    Console.WriteLine($"Please select the number of your tries! You can up to {MAX_TRIES} attempts");
                    if (int.TryParse(Console.ReadLine(), out tries) && tries <= MAX_TRIES)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, You can not have more than {MAX_TRIES} ");
                        continue;
                    }


                }
                while (true)
                {

                    Console.WriteLine($"Now please select how close you want to reach until you have the signal (Ooh!! So close!) , you can go up to {SO_CLOSE_MAX}!");
                    if (int.TryParse(Console.ReadLine(), out soClosehigh) && soClosehigh <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry you can only go up to {SO_CLOSE_MAX}");
                    }

                }
                Console.WriteLine($"Please write a number from {LOW_NUMBER} to {HIGH_NUMBER}!!");
                Random rng = new Random();
                randomNumber = rng.Next(LOW_NUMBER, HIGH_NUMBER);

                for (int i = 0; i < tries; i++)
                {

                    Console.WriteLine($"try {LOW_NUMBER + i}/{tries} ");
                   if (int.TryParse(Console.ReadLine(), out yourNumber) && yourNumber <= HIGH_NUMBER && yourNumber >= LOW_NUMBER)
                    {
                        Console.WriteLine($"You entered {yourNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. Please enter a number between {LOW_NUMBER} and {HIGH_NUMBER}");
                        i--;
                        continue;
                    }
                    if (randomNumber <= yourNumber + soClosehigh && yourNumber + SO_CLOSE_LOW <= randomNumber || randomNumber >= yourNumber - soClosehigh && yourNumber - SO_CLOSE_LOW >= randomNumber)
                    {
                        Console.WriteLine("Ooh!! So close!");
                    }
                    if (yourNumber < randomNumber)
                    {
                        Console.WriteLine("A little higher!");
                    }
                    if (randomNumber < yourNumber)
                    {
                        Console.WriteLine("A little lower!");
                    }

                    if (randomNumber == yourNumber)
                    {
                        Console.WriteLine("BRAVO!! YOU WON!! :)");
                        break;
                    }
                }
                Console.WriteLine($"The Lucky Number is . . .  {randomNumber}!!!");

                if (randomNumber != yourNumber)
                {
                    Console.WriteLine("Sorry you lost.. Maybe next time!");
                }

                Console.WriteLine("Do you want to play again?");
                Console.WriteLine($"Press (SPACE) to play or anything else to quit. . .");
                Console.WriteLine("********************************************************\n");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if(keyInfo.Key == ConsoleKey.Spacebar)
                {
                    continue;
                }
                else
                {
                    break;
                }   
            }
            Console.WriteLine("OK!! See you later!!");

        }
    }
}
