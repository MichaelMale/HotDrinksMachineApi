using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    /// <summary>
    /// Base class for all drinks that can be made using the HotDrinksMachineApi.
    /// </summary>
    public abstract class HotDrink
    {
        /// <summary>
        /// Constructor for objects of type HotDrink.
        /// </summary>
        /// <param name="id">The ID pertinent to the type of drink.</param>
        /// <param name="name">The name of the drink.</param>
        /// <param name="image">Links to an image of the drink.</param>
        protected HotDrink(DrinkType id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }

        public DrinkType Id { get; set; }
        public string Name { get; set; }
        public List<string> Steps { get; set; }
        public string Image { get; set; }
         
        /// <summary>
        /// Initialises the Steps instance variable with a new list, containing steps that are used across all hot drinks.
        /// </summary>
        protected virtual void AddSteps()
        {
            Steps = new List<string>
            {
                "Boil some water"
            };
        }
    }
}
