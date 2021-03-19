using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    /// <summary>
    /// Models a lemon tea.
    /// </summary>
    public class LemonTea : HotDrink
    {
        /// <summary>
        /// Constructor for objects of type LemonTea.
        /// </summary>
        public LemonTea() : base(DrinkType.LemonTea, "Lemon Tea", "lemon-tea.jpg")
        {
            AddSteps();
        }

        /// <summary>
        /// Adds steps relative to lemon tea.
        /// </summary>
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
