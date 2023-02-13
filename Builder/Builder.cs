using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Builder
    {
        static void Main(string[] args)
        {

            var sandwichBuilder = new SandwichBuilder();
            sandwichBuilder
                .AddBread(BreadType.WholeGrain)
                .AddCheese(CheeseType.Swiss)
                .AddMeat(MeatType.Turkey)
                .AddVegetable("Lettuce")
                .AddVegetable("Tomato")
                .ToastBread(true);

            var sandwich = sandwichBuilder.Build();
        }
    }
}
