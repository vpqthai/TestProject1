
using StudentServiceLib;

namespace _520H0577
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreIs8_LetterShouldBe_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void ScoreIs7_LetterShouldBe_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void ScoreIs5_LetterShouldBe_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void ScoreIs3dot5_LetterShouldBe_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void ScoreIsLessThan3dot5_LetterShouldBe_E()
        {
            Student s = new Student();
            s.Score = 3.4;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
        [TestMethod]
        public void ScoreGreater10_ShouldHaveException()
        {
            Student s = new Student();
            bool ExceptionOccured = false;
            try
            {
                s.Score = 11.4;
            } catch(SystemException)
            {
                ExceptionOccured = true;
            }
            Assert.AreEqual(true, ExceptionOccured);
        }
    }
}