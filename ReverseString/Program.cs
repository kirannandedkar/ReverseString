// See https://aka.ms/new-console-template for more information


//Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.
//Added Difficulty: Check if the given string is a palindrome.
//(a palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam or racecar.)


using System.Threading.Channels;

ReverseString();

void ReverseString()
{
    string input = "";
    Console.WriteLine("Please input string");
    input = Console.ReadLine();
    //string reversedString = new string(input.Reverse().ToArray()); // I commented this purposefully because this i had googled
    IEnumerable<char> reversedArray = input.ToCharArray().Reverse();
    string reversedString = null;
    foreach (var str in reversedArray)
    {
        reversedString += str;
    }
    Console.WriteLine($"Reversed string is {reversedString}");
    if (input == reversedString)
        Console.WriteLine("This is Palindrome");
}
