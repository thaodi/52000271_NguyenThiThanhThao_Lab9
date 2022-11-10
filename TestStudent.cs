global using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Score9_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Thao";
            s.Age = 20;
            s.Score = 9;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7Half_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 7.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score6_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Danh";
            s.Age = 20;
            s.Score = 6;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score4_Should_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Duc";
            s.Age = 20;
            s.Score = 4;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score1HAlf_Should_ReturnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Phuong";
            s.Age = 20;
            s.Score = 1.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        public void Score0_Should_ReturnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Khanh";
            s.Age = 20;
            s.Score = 0;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void exceptionScore()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Khanh";
            s.Age = 20;
            s.Score = 12;
        }

        [TestMethod]
        public void addFirstStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Thao", Age = 20, Score = 9 };

            bool status = sv.addStudent(s);

            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void addFirstStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Thao", Age = 20, Score = 9 };

            bool status = sv.addStudent(s);

            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }
    }
}