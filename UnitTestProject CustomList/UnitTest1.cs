using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraseodymiumTDD;

namespace UnitTestProject_CustomList
{
    [TestClass]
    public class CustomList
    {
        //public int count {get;}
        //public in Capacity {get; set;}

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
        public void Add_String_AddStringToList()
        {
            //Arrange
            CustomList<string> mylist = new CustomList<string>();
            string value1 = "Test Thing 1";
            string expected = "Test Thing 1";
            string actual;
            //Act
            myList.Add(value1);
            actual = mylist[0];
            //Assert
            Assert.AreEqual(expected,actual);
        }
        public void Add_String_AddMultipleString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected;
            string string1 = "Test String 1";
            string string2 = "Test String 2";
            expected = string1 + string2;
            string actual = "Test String 1" + "Test String 2";
            //Act
            myList.Add(string1);
            myList.Add(string2);
      
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_Capacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected;
            expected = 4;
            int actual = expected;
            // Act
            myList.Capacity(expected);
            //Assert
            Assert.AreEqual(expected, actual)
        }


    }
            //Remove Test Methods
   
}
            //if (count == item.Length)
            //   Array.Resize(item, item.Length * 2)
            //   item[count++] = item;
