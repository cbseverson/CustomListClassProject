using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project;

namespace Custom_List_Project_Tests
{
    [TestClass]
    public class CustomListTest
    {   
        [TestMethod]
        public void Add_Double_CorrectIndexLocation()
        {
            CustomList<double> MyList = new CustomList<double>();
            //Arrange
            double type = 2;

            //Act
            MyList.Add(type);

            //Assert
            Assert.AreEqual(MyList[0], type);
        }
        [TestMethod]
        public void Add_Length_IndexLength()
        {
            CustomList<int> MyList = new CustomList<int>();
            //Arrange
            int total = 1;
            int total1 = 2;
            int total2 = 3;

            //Act
            MyList.Add(total);
            MyList.Add(total1);
            MyList.Add(total2);

            //Assert
            Assert.AreEqual(MyList.Count, 3);
            //.Count is used for lists, .Length is used for arrays
        }
        [TestMethod]
        public void Add_String_AddDateTypesList()
        {
            CustomList<string> MyList = new CustomList<string>();
            //Arrange
            string type = "data";
            string type1 = "numbers";

            //Act
            MyList.Add(type);
            MyList.Add(type1);

            //Assert
            Assert.AreNotEqual(MyList[0], MyList[1]);
            //shows that they are equal data types
        }
        [TestMethod]
        public void Add_Int_AddDateTypesList()
        {
            CustomList<int> MyList = new CustomList<int>();
            //Arrange
            int type = 1;
            int type1 = 2;

            //Act
            MyList.Add(type);
            MyList.Add(type1);

            //Assert
            Assert.AreNotEqual(MyList[0], MyList[1]);
            //shows that they are equal data types
        }
        [TestMethod]
        public void Remove_Object_TotalList()
        {
            CustomList<string> MyList = new CustomList<string>();
            //Arrange
            string type2 = "word";

            //Act
            MyList.Add(type2);
            MyList.Remove(type2);

            //Assert
            Assert.AreNotEqual(MyList.Count, 0);
        }
        [TestMethod]
        public void Count_Objects_Array()
        {
            CustomList<int> MyList = new CustomList<int>();
            //Arrange
            int data1 = 1;
            int data2 = 2;
            int data3 = 3;

            //Act
            MyList.Add(data1);
            MyList.Add(data2);
            MyList.Add(data3);

            //Assert
            Assert.AreEqual(MyList.Count, 3);
        }

        [TestMethod]
        public void Double_Array_ArraySize()
        {
            //Arrange
            

            //Act
            

            //Assert
            
        }
        [TestMethod]

        public void Add_Instance_TotalList()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void Count_Array_TotalLength()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Subtract_Instance_TotalList()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void Zipper_Add_CombineTogether()
        {
            CustomList<int> cl = new CustomList<int>();
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        //need to figure out what to test here
        public void Exception_Expected_Total()
        {
            CustomList<int> cl = new CustomList<int>();
            //Arrange

            //Act - it will pass if it divides by zero

            //Assert - don't need an assert here

        }
    }
}
