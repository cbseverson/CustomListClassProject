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
        public void Add_StringInt_AddDateTypesList()
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
        }
        [TestMethod]
        public void Remove_Object_TotalList()
        {
            //Arrange
            string type2 = "word";

            //Act
            MyList.Add(type2);
            MyList.Remove(type2);

            //Assert
            Assert.AreEqual(MyList.Count(type2), 0);
        }
        [TestMethod]
        public void Remove_Object_TotalList()
        {
            //Arrange
            string type2 = "word";

            //Act
            MyList.Add(type2);
            MyList.Remove(type2);

            //Assert
            Assert.AreNotEqual(MyList.Add(type2)), MyList[0]);
        }
        [TestMethod]

        public void Add_Instance_TotalList()
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

    }
}
