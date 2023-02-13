using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegetables { get; set; }

        public Sandwich(SandwichBuilder builder)
        {
            BreadType = builder.BreadType;
            IsToasted = builder.IsToasted;
            CheeseType = builder.CheeseType;
            MeatType = builder.MeatType;
            Vegetables = builder.Vegetables;
        }
    }
}
