
//initializing the variable to prompt the user further on to repeat the program
bool goagain = true;
do
{
    //prompting the user to input their integer 
    Console.WriteLine("Please input an integer value");
    int userinput = int.Parse(Console.ReadLine());
    Console.WriteLine("You have entered " + userinput + ". ");
    //creating a method to square the user input for further use in the output table
    static int square(int userinput)
    {
        int sq = userinput * userinput;
        return sq;
    }
    //creating a method to cube the user input for further use in the output table 
    static int cube(int userinput)
    {
        int cb = userinput * userinput * userinput;
        return cb;
    }
    //providing a check to see if the user input a valid response
    if (userinput <= 0)
    {
        //if an invalid response was made then the user will be notified and the program will exit
        Console.WriteLine("You have input an invalid response please restart the program and try again");
        break;
    }
    else if (userinput > 1290)
    {
        Console.WriteLine("You have input a number too large please restart the program and try again");
        break;
    }
    do
    {
        Console.WriteLine("Number\tSquared\tCubed");
        Console.WriteLine("=======|=======|=======|");
        for (int i = 1; i <= userinput; i++)
        {
            Console.WriteLine(String.Format("{0,8}{1,8}{2,8}", i , square(i) , cube(i)));
        }
    } while (false);
    Console.WriteLine("Would you like to restart the program? (y/n)");
    string choice = (Console.ReadLine());
    if (choice == "y")
    {
        goagain = true;
    }
    else
    {
        goagain = false;
    }
}while (goagain == true);