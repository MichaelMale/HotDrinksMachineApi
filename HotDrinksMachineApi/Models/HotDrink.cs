using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachineApi.Models
{
    public class HotDrink
    {

        public string Name { get; set; }
        public List<string> Steps { get; set; }

        public virtual void AddSteps()
        {
            Steps.Add("Boil some water");
        }
    }
}
