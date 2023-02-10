// See https://aka.ms/new-console-template for more information

using Strategy;


Console.WriteLine("Cost is " +new Order(new ExpressShippingCostStrategy()).CalculateShippingCost());