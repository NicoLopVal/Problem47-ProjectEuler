
List<double> allPrimes = new();
allPrimes.Add(2);

int repetitions = 0;
int targetRepetitions = 4;
int totalDifPrimeMax = 4;

double answer = 0;
double counter = 3;

while (true)
{
    bool isPrime = true;
    int innerPrimeCounter = 0;

    foreach(double prime in allPrimes)
    {
        if(counter%prime == 0)
        {
            isPrime = false;
            innerPrimeCounter++;
        }
    }
    if(isPrime)
        allPrimes.Add(counter);
    if(innerPrimeCounter == totalDifPrimeMax)
    {
        repetitions++;
    }
    else
    {
        repetitions = 0;
    }
    if(repetitions == targetRepetitions)
    {
        answer = counter - targetRepetitions + 1;
        break;
    }
    counter++;
}

Console.WriteLine("The first number of the four consecutive integers to have four distinct prime factors each is: " + answer);