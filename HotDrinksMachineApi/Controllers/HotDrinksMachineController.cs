using Microsoft.AspNetCore.Mvc;
using HotDrinksMachineApi.Exceptions;
using HotDrinksMachineApi.Models;

namespace HotDrinksMachineApi.Controllers
{
    [ApiController]
    public class HotDrinksMachineController : ControllerBase
    {
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
