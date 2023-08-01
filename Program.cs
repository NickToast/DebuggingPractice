// Challenge 1
// bool amProgrammer = "true"; | cannot set a string value to a bool variable
bool amProgrammer = true;

// int Age = 27.9; | for decimals, use double as the data type
double Age = 27.9;

List<string> Names = new List<string>();
// Names = "Monica"; trying to redefine the List Names to a string
Names.Add("Monica");

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");

// This is a tricky one! Hint: look up what a char is in C#
// string MyName = 'MyName'; cannot use single quotation marks because they are used for variable char
string MyName = "MyName";


// Challenge 2
//Numbers.Count - 1 or the index will be out of range
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}


// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        //What should this do?
        // num = 0;
        Console.WriteLine($"{num} is divisible by 3.");
    }
}


// Challenge 5
// What can we learn from this error message?
//Property or indexer 'string.this[int]' cannot be assigned to -- it is read only
string MyString = "superduberawesome";
// MyString[7] = "p";
//Strings are immutable, so this is not a valid code


// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();

//Gets a random number from 0-11
int randomNum = rand.Next(12);

//This conditional will never run because 12 is not in its range
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}

