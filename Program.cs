// See https://aka.ms/new-console-template for more information
var greetings = new List<String>{
    "Hello",
    "World,",
    "Part 13!"
};

var msg = "";
foreach (var greeting in greetings)
{
    msg += " " + greeting;
}

Console.WriteLine(msg);
