public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Assign a default value before accessing the property
        this.MyProperty = 0;
        int value = this.MyProperty;

        // Handle potential null references using null-conditional operator
        string myString = null;
        int? length = myString?.Length; // length will be null if myString is null

        // Use double for accurate division
        double result1 = 10.0 / 3.0; 

        // Use appropriate logical operators and pay attention to operator precedence.
        bool a = true;
        bool b = false;
        if (a && (b || a)) // Corrected use of parentheses to control operator precedence
        {
            Console.WriteLine("This will execute.");
        }

        // Using "==" instead of "=" in conditionals
        int x = 5;
        if (x == 10) // Corrected conditional statement
        {
            Console.WriteLine("This will not execute.");
        }
        else
        {
            Console.WriteLine("This will execute.");
        }
        // Proper handling of exceptions
        try
        {
            // Code that might throw an exception
        }
        catch (Exception ex)
        {
            // Log the exception and take appropriate action (e.g., retry, display error message, etc.)
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}