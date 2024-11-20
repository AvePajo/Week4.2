

Random rnd = new Random();
int userGuess;

int numberOfTries = 0;
//bool loopActive = true;

int cpuRandom = rnd.Next(1, 4);

while (numberOfTries < 3)
{

    Console.WriteLine("try to guess the cpu number:");
    userGuess = Convert.ToInt32(Console.ReadLine());
    numberOfTries++;
    if(userGuess == cpuRandom)
    {
        Console.WriteLine("You won!");
        break;
    }

}
Console.WriteLine($"The number of tries: {numberOfTries}");
Console.WriteLine("Have a nice day!");