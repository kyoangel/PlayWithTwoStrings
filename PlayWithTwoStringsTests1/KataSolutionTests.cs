using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayWithTwoStrings.Tests
{
    [TestClass()]
    public class KataSolutionTests
    {
        private KataSolution _kataSolution = new KataSolution();

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod()]
        public void two_string_no_same_char_just_append()
        {
            var actual = _kataSolution.WorkOnStrings("abc", "def");
            Assert.AreEqual("abcdef", actual);
        }

        [TestMethod()]
        public void two_string_has_only_one_same_char_just_append()
        {
            var actual = _kataSolution.WorkOnStrings("abc", "cde");
            Assert.AreEqual("abCCde", actual);
        }

        [TestMethod()]
        public void abab_with_bababa_should_be_ABABbababa()
        {
            var actual = _kataSolution.WorkOnStrings("abab", "bababa");
            Assert.AreEqual("ABABbababa", actual);
        }

        [TestMethod()]
        public void ab_with_aba_should_be_aBABA()
        {
            var actual = _kataSolution.WorkOnStrings("ab", "aba");
            Assert.AreEqual("aBABA", actual);
        }

        [TestMethod()]
        public void abcdeFgtrzw_with_defgGgfhjkwqe_should_be_abcDeFGtrzWDEFGgGFhjkWqE()
        {
            var actual = _kataSolution.WorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe");
            Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", actual);
        }

        [TestMethod()]
        public void very_complicate_case()
        {
            var actual = _kataSolution.WorkOnStrings("eYHPTIOyZgVygK", "yzQeeJzFTZZZNPSuAeweiIklUNQLRKDmUPnOkxOvGtOQUIaIhLvuJGKPoFjrSONivMeXCfkcpaxPUuqlMhEgoiCn");
            Assert.AreEqual("eyHpTIOYzGvYGkYZQEEJZFtzzzNpSuAEwEIiKlUNQLRkDmUpnoKxoVGToQUiaiHLVuJGkpOFjrSoNIVMEXCfKcPaxpUuqlMHegOICn", actual);
        }
    }
}