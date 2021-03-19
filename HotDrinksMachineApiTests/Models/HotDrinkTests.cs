using System.Collections.Generic;
using HotDrinksMachineApi.Models;
using Xunit;
using FluentAssertions;


namespace HotDrinksMachineApiTests.Models
{
    public class HotDrinkTests
    {

        [Fact]
        public void AddSteps_WhenCoffee_ShouldReturnCorrectData()
        {
            // Arrange

            var testHotDrink = new Coffee();
            const string expectedName = "Coffee";
            const string expectedImage = "coffee.jpg";
            var expectedSteps = new List<string>
            {
                "Boil some water",
                "Brew the coffee grounds",
                "Pour coffee in the cup",
                "Add sugar and milk"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(expectedName);
            testHotDrink.Image.Should().Be(expectedImage);
            testHotDrink.Id.Should().Be(DrinkType.Coffee);
        }

        [Fact]
        public void AddSteps_WhenLemonTea_ShouldReturnCorrectData()
        {
            // Arrange

            var testHotDrink = new LemonTea();
            const string expectedName = "Lemon Tea";
            const string expectedImage = "lemon-tea.jpg";
            var expectedSteps = new List<string>
            {
                "Boil some water",
                "Steep the water in the tea",
                "Pour tea in the cup",
                "Add lemon"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(expectedName);
            testHotDrink.Image.Should().Be(expectedImage);
            testHotDrink.Id.Should().Be(DrinkType.LemonTea);
        }

        [Fact]
        public void AddSteps_WhenChocolate_ShouldReturnCorrectData()
        {
            // Arrange

            var testHotDrink = new Chocolate();
            const string expectedName = "Chocolate";
            const string expectedImage = "hot-chocolate.jpg";
            var expectedSteps = new List<string>
            {
                "Boil some water",
                "Add drinking chocolate powder to the water",
                "Pour chocolate in the cup"
            };

            // Assert

            testHotDrink.Steps.Should().BeEquivalentTo(expectedSteps);
            testHotDrink.Name.Should().Be(expectedName);
            testHotDrink.Image.Should().Be(expectedImage);
            testHotDrink.Id.Should().Be(DrinkType.Chocolate);
        }

    }
}
