using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    public class HotDrink
    {

        public DrinkType Id { get; set; }
        public string Name { get; set; }
        public List<string> Steps { get; set; }

        public virtual void AddSteps()
        {
            Steps = new List<string>
            {
                "Boil some water"
            };
        }
    }
}
