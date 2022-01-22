﻿using System.Globalization;
using Aula146.Entities;
using Aula146.Entities.Exceptions;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Account account = new Account(number, holder, balance, limit);

Console.Write("Enter amount for withdraw: ");
double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
try
{
    account.Withdraw(withdraw);
    Console.WriteLine(account);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error" + e.Message);
}
