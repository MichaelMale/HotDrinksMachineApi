using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    /// <summary>
    /// Models a coffee.
    /// </summary>
    public class Coffee : HotDrink
    {
        /// <summary>
        /// Constructor for objects of type Coffee.
        /// </summary>
        public Coffee() : base(DrinkType.Coffee, "Coffee", "coffee.jpg")
        {
            AddSteps();
        }
        
        /// <summary>
        /// Adds steps relative to coffee.
        /// </summary>
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
