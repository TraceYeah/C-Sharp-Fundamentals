/*Create a greeting to the user of the application. First, using Console.WriteLine(), give a message to the user that they need to enter their name.
  Then, capture the name in a variable of type string.
  Finally, write "Hello ", and then the entered name, to the console. Do this in one statement so "Hello " + variable.

        Console.WriteLine("Please Enter Your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);*/

/*Create a variable of type string named input which will accept input from the console. Use the ReadLine() method.Do this all in one single statement.

        string input = Console.ReadLine();*/

/*Create a variable of type bool named isActive (case-sensitive). Assign it the value false. Do this in one single statement

        bool isActive = false;*/

/*Create a variable of type decimal named price. In the same statement as the creation of the variable, set it to 100.0.

        decimal price = 100.0M;*/

/*Create a variable of type string named greeting. In the same statement, set its value to "Hello". Make sure to use the exact same value for the string value.
     
        string greeting = "Hello";*/

/*Create a constant double variable named profitMargin. Set its value to 0.17. Use the correct literal to indicate we're working with double when declaring.
      
        const double profitMargin = 0.17;*/

/*You are going to sum up two integer variables, and assign that sum to a third variable.
  First, create a variable a of type int and set it to 3 (use a single statement to do so). Then, create a second variable b, also of type int, 
  and initialize it to 5.
  Create a third variable c of type int, and in the same statement as its creation, set it to the result of the sum of a and b.

       int a = 3;
       int b = 5;
       int c = a + b;*/

/*Create a variable named a of type int, and initialize it in the same statement to 1.
use the compound operator to increase its value by 3.

      int a = 1;
      a += 3;*/

/*Create a variable named aChar of type char, and in the same statement, initialize its value to 'b'.
      
     char aChar = 'b';*/

/*Create a variable named aChar of type char, and set it, in the same statement, to 'a'.
  Next, create a variable named isWhiteSpace of type bool. Set it, in the same statement, to the result of checking if aChar is a white space character.
      
     char aChar = 'a';
     bool isWhiteSpace = char.IsWhiteSpace(aChar);
     Console.WriteLine(isWhiteSpace); 

/*First, create a variable of type DateTime named startDate and set it, in the same statement, to a new date: March 05, 2022. 
  Use the 3 argument constructor to do so.
  Second, create a second DateTime variable named endDate. Set its value, again in the same statement, to today's date. 
  The time component should be set to 00:00:00.
     
     DateTime startDate = new DateTime(2022, 03, 05);
     DateTime endDate = new DateTime.Today;*/

/*First, create a variable of type long named myLargeValue. In the same statement, set its value to 123456789.
  Next, create a variable intValue of type int.
  In the same statement as its creation, set its value equal to myLargeValue and apply, if needed, the correct
  cast for the code to be correct.

     long myLargeValue = 123456789;
     int intValue = (int)myLargeValue;*/

/*Create an implicitly typed variable named a and set it to 10 (so an integer value).
     var a = 10;*/

/*You are going to calculate the sum of two values entered by the user. 
 Ask the user for a first value by displaying to the Console "Enter a first value:". 
 Make sure to use Console.WriteLine() to display this text. 
 Capture the user input in a variable named stringValue1 of type string, and use Console.ReadLine() for this. 
 Then, display "Enter a second value:", and store the second value in a variable called stringValue2.

 Now parse the entered values. 
 Create a variable intValue1 of type int, and set it to the result of parsing, using int.Parse(), stringValue1.
 Repeat the process by parsing stringValue2 into a new variable intValue2.

 Finally, create a variable sum, using implicit typing, and set it to the sum of intValue1 and intValue2, in that left-to-right order.

     Console.WriteLine("Enter a first value: ");
     string stringValue1 = Console.ReadLine();
     Console.WriteLine("Enter a second value: ");
     string stringValue2 = Console.ReadLine();

     int intValue1 = int.Parse(stringValue1);
     int intValue2 = int.Parse(stringValue2);

     var sum = intValue1 + intValue2;*/

/*Create a variable named validAge of type bool. 
  In the same statement as its creation, set it to the result of checking if age is greater than 18.
     
     bool validAge > 18;

/*Create a variable named validAge of type bool. 
  In the same statement as its creation, set it to the result of checking if age is less than or equal to 65.

     bool validAge = (age <= 65);*/

/*Using an if statement, write to the console "You are eligible", then "Congratulations" 
  if the age is greater than 18. Use two WriteLine() calls.

  int age = 33;

  if (age > 18)
  { 
    Console.WriteLine("You are eligible");
    Console.WriteLine("Congratulations");
  }

*/

/*Using an if statement, write to the console "You are eligible", then "Congratulations" if the age is greater than 18. Use two WriteLine() calls.
  Use an else statement that outputs "You aren't eligible" then "Sorry"in all other cases. Also use two WriteLine() calls.

    int age = 45;

    if (age > 18)
    {
      Console.WriteLine("You are eligible");
      Console.WriteLine("Congratulations");
    }
    else
    {
      Console.WriteLine("You aren"t eligible");
      Console.WriteLine("Sorry");
    }
*/

/*Using an if statement, write to the console "You are eligible" and "Congratulations" if the age is equal to 18.
  Use two WriteLine() calls.

  int age = 45;

  if (age == 18)
  {
    Console.WriteLine("You are eligible");
    Console.WriteLine("Congratulations");
  }
*/

/*You are going to compare two values entered by the user.
 Ask the user for a first value by displaying to the Console "Enter a first number:".
 Make sure to use Console.WriteLine() to display this. Capture the user input in a variable named stringValue1 of type string,
 and use Console.ReadLine() for this.

 Then, display "Enter a second number:", and store the second value in a variable called stringValue2.

 Now, create an int variable intValue1, and set it to the result of parsing (using int.Parse()) the value of stringValue1. 
 Do the same for an intValue2 variable.

 Finally, create an if/else statement. In all comparisons, have intValue1 first, then intValue2:

 In the if part, check if intValue1 and intValue2 are equal. If so, display "The values are equal!" to the console.
 In the else if, check if intValue1 is less than intValue2, and if true, display "The first value is smaller!".
 Finally, in the else, display "The second value is smaller!".

    
  Console.WriteLine("Enter a first number");
  string stringValue1 = Console.ReadLine();

  Console.WriteLine("Enter a second number");
  string stringValue2 = Console.ReadLine();

  int intValue1 = int.Parse(stringValue1);
  int intValue2 = int.Parse(stringValue2);
  
  if (intValue1 == intValue2)
  {
    Console.WriteLine("The values are equal!");
  }
  else if (intValue1 < intValue2)
  {
    Console.WriteLine("The first value is smaller!");
  }
  else
  {
    Console.WriteLine("The second value is smaller");
  }
*/

/*You need to write to the console (using the Console.WriteLine()method) the following output:

    1
    2
    3
    4
    5
    6
    7
    8
    9
    10
    Create a while loop that generates this output. Once the while loop completes, the value of i must be 11. 
    Note: use Console.WriteLine(i) to display the value of i. Increase the value in a separate statement.

  int i = 1;

  while (i <= 10)
  {
    Console.WriteLine(i);
    i++;
  }
  Console.WriteLine(i);
*/

/*You are going to use a loop to sum up numbers. For example, if the user enters 5, you will return 5 + 4 + 3 + 2 + 1, so 15.
 
  First, right after sum is assigned 0, capture the user input from Console.ReadLine() into a string variable named stringValue.
  Next, create a variable startValue, of type int, and in the same statement, set it to the result of parsing stringValue. 
  Use int.Parse() for this.

  Next, write a for loop to calculate the sum as explained above.

  The iterator must be named i and must be of type int, and its initial value set to startValue.
  Then within the loop's condition, check if i is larger than 0. In this comparison, have i first.
  Inside the for loop, add i to sum using the compound operator +=.

  Console.WriteLine("Enter a value: ");
  int sum = 0;

  string stringValue = Console.ReadLine();
  int startValue = int.Parse(stringValue);

  int i = startValue;
  
  if (i > 0)
  { 
    (i + sum);
  }

/*You need to write the following output to the console:

0
1
2
3
4
5
6
7
8
9
To do so, create a for loop. The counter must be named i and it must be initialized to 0. 
Inside the body of the for loop, use one Console.WriteLine() statement to write the value of i to the console.

  for (int i = 0; i < 10; i++)
  {
    Console.WriteLine(i);
  }*/

/*
      


  
    

  
 

/* 
*-* What is C# and what are some of its features?

    C# is an object-oriented programming language that was developed by Microsoft in the early 2000s. 
    It is designed to be simple, modern, and safe, with a strong focus on type safety, memory management, 
    and garbage collection.

    C# is a strongly typed language, which means that variables must be declared with a specific data type before they can be used.
    It supports a variety of data types, including integer, floating-point, boolean, and string, among others. 
    C# also includes features like classes, objects, inheritance, and polymorphism, which are core principles of 
    object-oriented programming.

    Overall, C# is a powerful and versatile programming language that is widely used in a variety of applications, 
    including desktop and mobile development, game development, web development, and more. \
    It has a large and active community of developers, 
    and there are many resources available online to help you learn and improve your skills in C#.    

*-* What is the difference between a class and an object in C#?

    a class is like a cookie cutter that defines the shape of a cookie, 
    while an object is like the cookie itself that has its own distinct properties, such as flavor and texture.

*-* What are the access modifiers in C# and what do they mean?

    Access modifiers in C# are keywords that determine the visibility and accessibility of classes, methods, and other members 
    of a program. There are five access modifiers in C#:

*1* Public: A public member can be accessed from anywhere within the program, including other classes and assemblies.

*2* Private: A private member can only be accessed within the same class where it is declared. 
   It is not visible or accessible outside of that class.

*3* Protected: A protected member is accessible within the same class and any derived classes (classes that inherit from the base class).
   It is not visible or accessible outside of that class hierarchy.

*4* Internal: An internal member can be accessed within the same assembly (a collection of compiled code files) 
   but is not visible or accessible outside of that assembly.

*5* Protected internal: A protected internal member is accessible within the same assembly and any derived classes 
  (classes that inherit from the base class), even if they are in a different assembly.

  These access modifiers help control the visibility and accessibility of a program's members,
  which can help improve the program's security, maintainability, and flexibility. By setting appropriate access modifiers, 
  you can ensure that your program's members are only accessible by the appropriate code, and that they are not accidentally 
  modified or accessed in unintended ways.

*6* What is a method in C#?
    
    Methods are code blocks which contain a number of code statements. They have a name and by calling that name we can invoke
    that method and the code that lives within that method. Methods are always declared inside of a class or a struct.
   
    *Code Block
    *Receives parameters and (optionally) returns values
    *Readable code and code reuse
    *Declared inside of a class or a struct
     
    <acess modifier> <return type> Method_Name (Parameters)
    { 
      //method statement
    }
    
*-* What is polymorphism and how is it implemented in C#?
*-* What is inheritance in C# and how is it used?  *-* What is an interface in C# and how is it different from a class?
*-* What is the difference between an abstract class and an interface?
*-* What is the purpose of the "using" statement in C#?
*-* What is a delegate in C# and how is it used?
*-* What is the difference between a value type and a reference type in C#?










//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();

string name2 = Console.ReadLine();

string name_2 = Console.ReadLine();

string Name_2 = Console.ReadLine();

//string 2Name = Console.ReadLine(); cannot start with a number

int a = 2;
int b = a + 3;
bool c = true;
*/


//int monthlyWage = 1234;

//int months = 12, bonus = 1000;

//bool isActive = true;

//double rating = 99.25;

//byte numberOfEmployees = 300; // will not work because byte 0-255

//int hoursWorked;

//hoursWorked = 125;

//hoursWorked = 148;


//const double interestRate = 0.07;

//string firstString = "this is the first string";

//string secondString = string.Empty;

//string firstName = "Bethany";
//string lastName = "Smith";

//string emptyString = "";



//int numberOfHoursWorked = 165;

//double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
//Console.WriteLine(currentMonthWage);

//ratePerHour += 3;
//Console.WriteLine(ratePerHour);

//if (currentMonthWage > 2000)
// Console.WriteLine("Top paid employee!");

//int numberOfEmployees = 15;

//numberOfEmployees--;
//Console.WriteLine(numberOfEmployees);

//bool a;
//int b;



//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;

//char userSelection = 'a';
//char upperVersion = char.ToUpper(userSelection);

//bool isDigit = char.IsDigit(userSelection);

//bool isLetter = char.IsLetter(userSelection);

//DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

//DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime invalidDate = DateTime new DateTime(2025, 15, 11);// date doesn't exist

//DateTime startDate = hireDate.AddDays(15);
//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour.ToShortTimeString());

//int numberOfHoursWorked = 165;
//long veryLongMonth = numberOfHoursWorked;// works 

//double d = 123456789.0;

//int x = (int)d;

//int intVeryLongMonth = (int)veryLongMonth;

//Console.ReadLine(); 

//int age = 23;

//bool a = age == 23;

//Console.WriteLine("Age is 23: " + a);

//bool b = age >= 23;
//Console.WriteLine("Age is greater than 23: " + b);

//bool c = (age >= 18) && (age <= 65);
//Console.WriteLine("Age is between 18 and 65: " + c);

//int age1 = 16;
//int age2 = 64;
//bool d = (age1 >= 18) && (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);

//bool e = (age1 >= 18) || (age2 <= 65);
//Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65:  " + e);


//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("Too young to apply");
//    Console.WriteLine("Send email to candidate");
//}
//else if (age > 65)
//{
//    Console.WriteLine("sorry, the selected age is too old");
//    Console.WriteLine("Send email to candidate");
//}
//else
//{
//    Console.WriteLine("Great, you can now start with the application!");
//}




//Console.WriteLine("Choose the action you want to do: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");
//Console.WriteLine("99. Exit application");
//string selectedAction = Console.ReadLine();

//while (selectedAction != "99")
//{

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee...");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee...");
//            break;
//        default:
//            Console.WriteLine("Invalid input");
//            break;

//    }
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();

//}
//Console.WriteLine("Closing application");
//int i = 0;

//while (i = 0)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;

//while (i < max)
//{
//    Console.WriteLine(i);
//    i++;
//}
//Console.WriteLine("Loop end");

//testing git commits

//int i = 0;
//int j = 0;

//while (i < 10)    // nested while loop
//{
//    while (j < 10)
//    {
//        Console.WriteLine("i: " + i + "  j: " + j);
//        j++;
//    }
//    j = 0;
//    i++;
//}

//while (true)   
//{
//    Console.WriteLine(DateTime.Now);
//}

// for loop

//int sum = 0;

//for (int i = 0; i < 10; i++)
//{
//    sum = sum + i;
//}
//Console.WriteLine(sum);


/// /////////////////////// /// 
//string selectedAction = Console.ReadLine();
//do
//{
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee...");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee...");
//            break;
//        default:
//            Console.WriteLine("Invalid input");
//            break;

//    }

//} while (selectedAction != "99");

//Console.WriteLine("Closing application");

//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());

//for (int i = 0; i < max; i++)
//{
//    if (i==5)
//    {
//        Console.WriteLine("Bingo! " + i + " was found!");
//        continue;
//    }
//    Console.WriteLine(i);
//}

//mod 5 methods

//public int AddTwoNumbers(int a, int b)
//{
//    return a + b;
//}

//public int AddTwoNumbers(int a, int b)
//{
//    if (a > b)
//    {
//        return a + b;
//    }
//    return 0;
//}

//public void DisplaySum(int a, int b) //void return type indicates that the caller shouldn't expect a return from the method
//{
//    int sum = a _ + b;
//    Console.WriteLine("The sum is " + sum); 
//}

//DispaySum(3, 5); // Invoking a method : We can pass arguments: values for the parameter(s)

//Flow of Execution

//Console.WriteLine("Before DisplaySum");

//DisplaySum(3, 5);

//Console.WriteLine("After DisplaySum");


//public void DisplaySum(int a, int b);
//{
//    int sum = a + b;
//    Console.WriteLine("The sum is " + sum);
//}


//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());

//for (int i = 0; i < max; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("Bingo! " + i + " was found!");
//        break;
//    }
//    Console.WriteLine(i);
//}


int amount = 1234;
int months = 12;

CalculateYearlyWage(amount, months);

Console.ReadLine();



static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked);
{
    int monthlyWage = 0;
    Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
}