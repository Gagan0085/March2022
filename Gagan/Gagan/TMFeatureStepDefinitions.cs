using System;
using TechTalk.SpecFlow;

namespace Gagan
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into the TurnUp portal successfully")]
        public void GivenILoggedIntoTheTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new file")]
        public void WhenICreateANewFile()
        {
            throw new PendingStepException();
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
