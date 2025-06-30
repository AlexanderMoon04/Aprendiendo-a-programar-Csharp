    Random random = new Random(); 
    // Generate a random number between 1 and 10
    int randomNumber = random.Next(1, 11);
    int number = 0;
    while(number<1||number>10)
    {
    Console.WriteLine("Guess the number between 1 and 10!");
    Console.WriteLine("Enter your number: ");
    number = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine("The random number is: " + randomNumber);
    GuessTheNumber(number, randomNumber);

 static void GuessTheNumber(int number, int randomNumber)
{
    if(number == randomNumber)
    Console.WriteLine("Congratulations, you have guessed the number :D");
    if(number > randomNumber)
    Console.WriteLine("Your number is too high :(");
    else
    Console.WriteLine("Your number is too low :(");
}

