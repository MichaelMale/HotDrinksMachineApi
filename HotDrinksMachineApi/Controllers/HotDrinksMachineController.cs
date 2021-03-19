using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using HotDrinksMachineApi.Exceptions;
using HotDrinksMachineApi.Models;
using Microsoft.AspNetCore.Cors;

namespace HotDrinksMachineApi.Controllers
{
    /// <summary>
    /// The controller class for HotDrinksMachine.
    /// Contains method for getting a drink and returning an object of type HotDrink.
    /// </summary>
    [ApiController]
    public class HotDrinksMachineController : ControllerBase
    {
        /// <summary>
        /// Returns an object of type HotDrink based upon the DrinkType passed to the method.
        /// </summary>
        /// <param name="type">Object of type DrinkType to be passed to the method</param>
        /// <returns>
        /// HotDrink with the class pertinent to the DrinkType, InvalidDrinkTypeException if DrinkType passed is not one of the supported types.
        /// </returns>
        /// <example>
        /// <code>
        /// var coffee = GetDrink(DrinkType.Coffee);
        /// Console.WriteLine(coffee.ToString());
        /// </code>
        /// </example>
        [HttpGet("get-drink/{type}")]
        public ActionResult<HotDrink> GetDrink(DrinkType type)
        {
            return type switch
            {
                DrinkType.Coffee => new Coffee(),
                DrinkType.Chocolate => new Chocolate(),
                DrinkType.LemonTea => new LemonTea(),
                DrinkType.HotDrink => new HotDrink(),
                _ => throw new InvalidDrinkTypeException(type + " is not a valid drink type.")
            };
        }
    }
}
