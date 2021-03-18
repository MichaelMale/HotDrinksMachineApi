using System.Collections.Generic;
using HotDrinksMachineApi.Models;
using Xunit;
using FluentAssertions;


namespace HotDrinksMachineApiTests.Models
{
    public class HotDrinkTests
    {

        [Fact]
        public void AddSteps_WhenBaseClass_ShouldReturnCorrectData()
        {
            // Arrange

            HotDrink testHotDrink = new HotDrink();
            List<string> expectedSteps = new List<string>
            {
                "Boil some water"
            };

            // Act

            testHotDrink.AddSteps();

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().BeNullOrEmpty();
            testHotDrink.Id.Should().Be(DrinkType.HotDrink);
        }

        [Fact]
        public void AddSteps_WhenCoffee_ShouldReturnCorrectData()
        {
            // Arrange

            HotDrink testHotDrink = new Coffee();
            var name = "Coffee";
            List<string> expectedSteps = new List<string>
            {
                "Boil some water",
                "Brew the coffee grounds",
                "Pour coffee in the cup",
                "Add sugar and milk"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(name);
            testHotDrink.Id.Should().Be(DrinkType.Coffee);
        }

        [Fact]
        public void AddSteps_WhenLemonTea_ShouldReturnCorrectData()
        {
            // Arrange

            HotDrink testHotDrink = new LemonTea();
            var name = "Lemon Tea";
            List<string> expectedSteps = new List<string>
            {
                "Boil some water",
                "Steep the water in the tea",
                "Pour tea in the cup",
                "Add lemon"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(name);
            testHotDrink.Id.Should().Be(DrinkType.LemonTea);
        }

        [Fact]
        public void AddSteps_WhenChocolate_ShouldReturnCorrectData()
        {
            // Arrange

            HotDrink testHotDrink = new Chocolate();
            var name = "Chocolate";
            List<string> expectedSteps = new List<string>
            {
                "Boil some water",
                "Add drinking chocolate powder to the water",
                "Pour chocolate in the cup"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(name);
            testHotDrink.Id.Should().Be(DrinkType.Chocolate);
        }

    }
}
