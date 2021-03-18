using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    public class Coffee : HotDrink
    {
        public Coffee()
        {
            Id = DrinkType.Coffee;
            Name = "Coffee";
            AddSteps();
        }

        public sealed override void AddSteps()
        {
            base.AddSteps();
            Steps.AddRange(new List<string>
            {
                "Brew the coffee grounds",
                "Pour coffee in the cup",
                "Add sugar and milk"
            });
        }
    }
}
