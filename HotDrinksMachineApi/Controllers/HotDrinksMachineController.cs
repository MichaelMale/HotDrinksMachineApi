using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            switch (type)
            {
                case DrinkType.Coffee:
                    return new Coffee();
                case DrinkType.Chocolate:
                    return new Chocolate();
                case DrinkType.LemonTea:
                    return new LemonTea();
                default:
                    throw new InvalidDrinkTypeException(type + " is not a valid drink type.");
            }
        }
    }
}
