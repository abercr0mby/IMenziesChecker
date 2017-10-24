using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IMenziesCheckerTests
{
    [TestClass]
    public class MenziesApiCheckerTests
    {
        [TestMethod]
        public void CreatingACheckerIsNotNull()
        {
            var checker = new IMenziesAPIChecker();
            Assert.IsNotNull(checker);
        }

        [TestMethod]
        public void 
    }
}
