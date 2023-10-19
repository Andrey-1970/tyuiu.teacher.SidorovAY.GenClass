namespace tyuiu.teacher.SidorovAY.GenClass.Tests
{
    [TestClass]
    public class GenClassTests
    {
        [TestMethod]
        public void DoubleValueListValid()
        {
            MyList<double> myList = new MyList<double>();
            Assert.IsNotNull(myList);
            Assert.AreEqual(0, myList.Length);
            myList.Add(12.0);
            Assert.AreEqual(1, myList.Length);
            Assert.AreEqual(12.0, myList[0]);
        }
        [TestMethod]
        public void IntValueListValid()
        {
            MyList<int> myList = new MyList<int>();
            Assert.IsNotNull(myList);
            Assert.AreEqual(0, myList.Length);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            myList.Add(13);
            Assert.AreEqual(11, myList.Length);
            Assert.AreEqual(13, myList[10]);
        }
        [TestMethod]
        public void StringValueListValid()
        {
            MyList<string> myList = new MyList<string>();
            Assert.IsNotNull(myList);
            Assert.AreEqual(0, myList.Length);
            myList.Add("12");
            Assert.AreEqual(1, myList.Length);
            Assert.AreEqual("12", myList.GetItem(0));
        }
        [TestMethod]
        public void FindValid()
        {
            MyList<string> myList = new MyList<string>();
            Assert.IsNotNull(myList);
            Assert.AreEqual(0, myList.Length);
            myList.Add("111");
            myList.Add("222");
            myList.Add("333");
            Assert.AreEqual(1, myList.IndexOf("222"));
            Assert.AreEqual(-1, myList.IndexOf("22"));
        }
    }
}