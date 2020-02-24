using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void Test1()
        {
			Program p = new Program();
			string x = p.Prefix("hello");
            Assert.AreEqual(x, "5,1:hello");
        }
		
		[Test]
		public static void Test2()
		{
			Program p = new Program();
			string x = p.Prefix("");
            Assert.AreEqual(x, "0,0:");
		}
		
		[Test]
		public static void Test3()
		{
			Program p = new Program();
			string x = p.Prefix("what     ...  did you say??");
            Assert.AreEqual(x, "27,5:what     ...  did you say??");
		}
		
		[Test]
		public static void Test4()
		{
			Program p = new Program();
			string x = p.Prefix("Good day my name is bla");
            Assert.AreEqual(x, "23,6:Good day my name is bla");
		}
    }
}