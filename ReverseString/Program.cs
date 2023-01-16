// See https://aka.ms/new-console-template for more information


//Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.
//Added Difficulty: Check if the given string is a palindrome.
//(a palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam or racecar.)

//ReverseString();
ReverseStringWithOwnImplementation();
void ReverseString()
{
    Console.WriteLine("Please input string");
    string input = Console.ReadLine();
    //string reversedString = new string(input.Reverse().ToArray()); // I commented this purposefully because this i had googled
    IEnumerable<char> reversedArray = input.ToCharArray().Reverse();
    string reversedString = null;
    foreach (var str in reversedArray)
    {
        reversedString += str;
    }
    Console.WriteLine($"Reversed string is {reversedString}");
    if (input.ToUpper() == reversedString.ToUpper())
        Console.WriteLine("This is Palindrome");
}


void ReverseStringWithOwnImplementation()
{
    Console.WriteLine("Please input string");
    string input = Console.ReadLine();
    int inputStringLength = input.Length;
    string reversedString = "";
    char[] inputArray = input.ToCharArray();
    for (int i = input.Length-1; i >= 0; i--)
    {
        reversedString+= input[i];
    
    }
    Console.WriteLine($"Reversed string is {reversedString}");
    if (input.ToUpper() == reversedString.ToUpper())
        Console.WriteLine("This is Palindrome");
}