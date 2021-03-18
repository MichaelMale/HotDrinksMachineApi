using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    public class Chocolate : HotDrink
    {
        public Chocolate()
        {
            Name = "Chocolate";
            AddSteps();
        }

        public sealed override void AddSteps()
        {
            base.AddSteps();
            Steps.AddRange(new List<string>
            {
                "Add drinking chocolate powder to the water",
                "Pour chocolate in the cup"
            });
        }
    }
}
