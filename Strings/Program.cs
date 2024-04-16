

using System.Text;

string teststr1 = "";
String teststr2 = "";
//  ^^^ basically the same thing 

//Literal String ex.
string filepath1 = "c:\\ProgramFiles";
//Verbatim String ex.
string filepath2 = @"c:\ProgramFiles";

//
string s1 = "Hello ";
string s2 = s1;
s1 += "World";
Console.WriteLine(s1);

//String Interpolation and Composite Formatting
string s3 = "bean";
string s4 = "water";
Console.WriteLine($"Go drink your {s3}{s4}.");
Console.WriteLine("Go drink your {0}{1}.",s3,s4);

//String Builder (for when performing thousands of iterations)
var sb = new StringBuilder();
var testStringBuilder = sb.Append(s1);
Console.WriteLine(testStringBuilder);
