using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maths
{
    [TestClass]
    public class TestProgram
    {
        #region private attributes
        private string sign;
        private string testExpectedResult;
        private int testActualResult;
        private Program testProgram = null;
        #endregion

        [TestInitialize]
        public void Init()
        {
            testProgram = new Program();
            testActualResult = 0;
        }

        [TestCleanup]
        public void CleanUp()
        {
            testActualResult = 0;
        }

        [TestMethod]
        public void Test_Add_Sucess()
        {
        }
    }
}
