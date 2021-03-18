using System;
using FluentAssertions;
using HotDrinksMachineApi.Controllers;
using HotDrinksMachineApi.Models;
using Xunit;

namespace HotDrinksMachineApiTests.Controller
{
    public class HotDrinksMachineControllerTests
    {

        [Theory]
        [InlineData(DrinkType.Coffee, typeof(Coffee))]
        [InlineData(DrinkType.Chocolate, typeof(Chocolate))]
        [InlineData(DrinkType.LemonTea, typeof(LemonTea))]
        [InlineData(DrinkType.HotDrink, typeof(HotDrink))]
        public void GetDrink_ShouldReturnCorrectType(DrinkType drinkType, Type hotDrink)
        {
            // Arrange
            var controller = new HotDrinksMachineController();

            // Act
            var result = controller.GetDrink(drinkType);

            // Assert
            result.Value.Should().BeOfType(hotDrink);
        }
    }
}
