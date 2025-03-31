using System.Text;

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append("Hello, ");
stringBuilder.Append("World!");

Console.WriteLine(stringBuilder.ToString());

string str = $"Now is: {DateTime.Now}";
Console.WriteLine(str);