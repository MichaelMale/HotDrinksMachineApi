using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    public class LemonTea : HotDrink
    {
        public LemonTea()
        {
            Name = "Lemon Tea";
            AddSteps();
        }

        public sealed override void AddSteps()
        {
            base.AddSteps();
            Steps.AddRange(new List<string>
            {
                "Steep the water in the tea",
                "Pour tea in the cup",
                "Add lemon"
            });
        }
    }
}
