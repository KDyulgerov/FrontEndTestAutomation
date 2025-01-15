namespace UITestingPlaygroundTestProject.Tests
{
    public class DynamicTableTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            dynamicTable.OpenPage();
        }

        [Test, Order(1)]
        public void Test_VerifyingDynamicTablePageHeading_ShouldReturnTrue()
        {
            Assert.True(dynamicTable.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_VerifyingChromeCpuValue_ShouldReturnTrue()
        {
            Assert.True(dynamicTable.IsChromeCpuValueCorrect(), "The Chrome CPU value is not as expected.");
        }
    }
}
