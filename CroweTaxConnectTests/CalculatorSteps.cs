using System;
using TechTalk.SpecFlow;

namespace CroweTaxConnectTests.bin
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
	        return;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
	        return;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
	        return;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
	        return;
        }
    }
}
