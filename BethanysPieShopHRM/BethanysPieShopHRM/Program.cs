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

char aChar = ' ';
bool isWhiteSpace = char.IsWhiteSpace(aChar);
Console.WriteLine(isWhiteSpace ); 




