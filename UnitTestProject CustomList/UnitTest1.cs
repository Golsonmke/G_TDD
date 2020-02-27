using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraseodymiumTDD;

namespace UnitTestProject_CustomList
{
    [TestClass]
    public class CustomList
    {


        [TestMethod]

        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Add_Int_AddIntToList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_Int_AddTwoInt()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Add_String_AddStringToList()
        {
            //Arrange
            CustomList<string> mylist = new CustomList<string>();
            string value1 = "Test Thing 1";
            string expected = value1;
            string actual;
            //Act
            mylist.Add(value1);
            actual = mylist[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_String_AddMultipleString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected;
            string string1 = "Test String 1";
            string string2 = "Test String 2";
            expected = "Test String 2";

            //Act
            myList.Add(string1);
            myList.Add(string2);

            string actual = myList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Capacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected;
            expected = 4;
            int actual;
            // Act
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Increase_Capacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected;
            expected = 8;
            int actual;

            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Increase_Capacity2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected;
            expected = 8;
            int actual;

            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            myList.Add(12);
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Remove Test Methods
        [TestMethod]
        public void Remove_OneValue_CountDecrement()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;

            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            myList.Remove(67);

            //Assert
            Assert.AreEqual(expected, myList.Count);

        }
        [TestMethod]
        public void Remove_LastIndex_RemoveFromlist()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 34;
            
            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            myList.Remove(8);

            //Assert
            Assert.AreEqual(expected, myList[3]);
        }
        [TestMethod]
        public void Remove_AtIndex_RemoveIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 56;
            
            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(56);
            myList.Add(34);
            myList.Remove(56);

            //Assert
            Assert.AreEqual(expected, myList[2]);

        }
        [TestMethod]
        public void ToString_OneValue_ConvertInt()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            
            string expected = "67, 56, 98, 8, 34";
            string actual;

            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TwoValues_ConvertInt()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            var expected = "";
            string actual;

            //Act
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetEnumerator_IEnumerator()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();

            string expected = "67, 56, 98, 8, 34";
            string actual;

            //Act
            myList.Add(67);
            myList.Add(56);
            myList.Add(98);
            myList.Add(8);
            myList.Add(34);
            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverLoad_Plus()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = [1, 2, 3, 4, 5, 6];

            //Act
            CustomList<int> actual = list1 + list2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OperatorOverLoad_Plus2()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5, 6 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4 };
            CustomList<int> expected = { 1, 2, 3, 4, 5, 6 };
            //Act
            CustomList<int> actual = list1 + list2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
          
