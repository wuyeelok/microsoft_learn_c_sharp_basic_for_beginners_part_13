﻿// See https://aka.ms/new-console-template for more information
var greetings = new List<String>{
    "Hello",
    "World,",
    "Part 13!",
    "Welcome to",
    "C# Tutorials"
};

var msg = "";
foreach (var greeting in greetings)
{
    msg += " " + greeting;
}

Console.WriteLine(msg);

var greetArray = greetings.ToArray();
Console.WriteLine(greetArray.Length);
var greetLastItem = greetings[^1]; // ^1 is the last item
Console.WriteLine($"Last item of greet is {greetLastItem}");

foreach (var greet in greetings[1..4])
{
    Console.WriteLine(greet);
}

var simpleArr = new string[] { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
// simpleArr.Add() produce error on array
simpleArr = [.. simpleArr, "Kiwi", "Lemon", "Mango"]; // Add items to the end of Array
foreach (var item in simpleArr)
{
    Console.WriteLine(item);
}