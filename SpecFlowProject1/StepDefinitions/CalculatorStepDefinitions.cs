using Assignment_1;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calc;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calc = new Calculator();
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calc.num1 = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            calc.num2 = p0;
        }

        [When(@"the two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calc.Sub();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(result);
        }

        [When(@"the two numbers Multiply")]
        public void WhenTheTwoNumbersMultiply()
        {
            result = calc.Mul();
        }
        [Then(@"the result is multiplication (.*)")]
        public void ThenTheResultismultiplication(int p1)
        {
            result.Should().Be(p1);
        }
        [When(@"the two numbers Divided")]
        public void WhenTheTwoNumbersDivided()
        {
            result = calc.Div();
        }
        [Then(@"the result is division (.*)")]
        public void ThenTheResultisDivision(int p1)
        {
            result.Should().Be(p1);
        }
    }
}
