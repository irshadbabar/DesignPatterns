using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    public enum BreadType
    {
        White,
        WholeGrain
    }

    public enum CheeseType
    {
        Cheddar,
        Swiss
    }

    public enum MeatType
    {
        Turkey,
        Ham
    }

    public class SandwichBuilder
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegetables { get; set; }

        public SandwichBuilder()
        {
            Vegetables = new List<string>();
        }

        public SandwichBuilder AddBread(BreadType breadType)
        {
            BreadType = breadType;
            return this;
        }

        public SandwichBuilder AddCheese(CheeseType cheeseType)
        {
            CheeseType = cheeseType;
            return this;
        }

        public SandwichBuilder AddMeat(MeatType meatType)
        {
            MeatType = meatType;
            return this;
        }

        public SandwichBuilder AddVegetable(string vegetable)
        {
            Vegetables.Add(vegetable);
            return this;
        }

        public SandwichBuilder ToastBread(bool isToasted)
        {
            IsToasted = isToasted;
            return this;
        }

        public Sandwich Build()
        {
            return new Sandwich(this);
        }
    }
}
