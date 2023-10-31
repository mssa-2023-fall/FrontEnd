// See https://aka.ms/new-console-template for more information
using MortgageCalculatorLibrary;
using Spectre;
using Spectre.Console;
using System;
using System.Numerics;

Console.WriteLine("Hello, Home Buyer!");

Console.WriteLine("1. Build a new mortgage: ");
Console.WriteLine("2. View existing mortgage(s): ");
Console.WriteLine("3. Check federal rates. This will take you outside of the current app(development)"); 
Console.WriteLine("4. About Us: ");
Console.Write("Your selection: ");
var selection = int.Parse(Console.ReadLine());




Console.WriteLine("Enter the corresponding amounts below: ");
        Console.Write("Principal Amount: ");
        decimal principal = decimal.Parse(Console.ReadLine());
        Console.Write("Interest: ");
        decimal interest = decimal.Parse(Console.ReadLine());
        Console.Write("First Payment Date: ");
        DateTime firstPayment = DateTime.Parse(Console.ReadLine());
        Console.Write("Loan Term in years: ");
        int term = int.Parse(Console.ReadLine());
        Console.Write("Monthly escrow: ");
        decimal escrow = decimal.Parse(Console.ReadLine());
        
        Mortgage mortgage = new Mortgage(interest, principal, firstPayment, term, escrow);


Console.WriteLine(mortgage.CalculateMonthlyPayment());

