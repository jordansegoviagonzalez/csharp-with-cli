namespace SelectionStatementsLecture;

class Program
{
    static void Main(string[] args)
    {
        // A selection statement provides the meaning of choosing between two or more pahts of execution.
        
        //if-else statements
        
        // bool (is variable that can only carry true or falce).
        // condition is the argument.
        // the equals sign = is an operator.
        // the value is falce.

        bool condition = false;
        
        // if is a condition (condittion1) a block of code to be executed if condition is True
        // == means equal to for example: x==y

        if (condition == true)
        {
            Console.WriteLine("black color you see");
        }
        // else is conddition, block of codde to be exectuted if the condition1 is false and condition2 is false
        
        else
        {
            Console.WriteLine("white color you see");
        }
        
        Console.WriteLine("Continue on...\n");
        
        // int is an integer 
        // we put arguments into the variables name int
        // a and b are the arguments in the parameters 

        int a = 20;
        int b = 200;

        if (a == b)
        {
            Console.WriteLine("you will win the money");
        }
        else
        {
            Console.WriteLine("you will lose the money");
        }
        
        Console.WriteLine("Continue playing, I want all your money lol...\n");
        
        
        
        



    }
}