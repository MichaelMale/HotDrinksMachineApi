using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace HotDrinksMachineApi.Models
{
    /// <summary>
    /// Models a hot chocolate drink.
    /// </summary>
    public class Chocolate : HotDrink
    {
        /// <summary>
        /// Constructor for objects of type Chocolate.
        /// </summary>
        public Chocolate() : base(DrinkType.Chocolate, "Chocolate", "hot-chocolate.jpg")
        {
            AddSteps();
        }

        /// <summary>
        /// Adds steps relative to hot chocolate.
        /// </summary>
        protected sealed override void AddSteps()
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
