using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;

namespace RectangleTest
{

    [TestFixture]
    public class RectangleTest
    {
        

       
            Rectangle rectangle;
            //Testcase 1 for GetLength()
            [Test]
            public void GetLength_InputLength1_Width1()
            {
                //Arrange
                int length = 1;
                int width = 1;
                int expectedLength = 1;

                //Act
                rectangle = new Rectangle(length, width);
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }
            //Testcase 2 for GetLength()
            [Test]
            public void GetLength_InputLength10_Width10()
            {
                //Arrange
                int length = 10;
                int width = 10;
                int expectedLength = length;

                //Act
                rectangle = new Rectangle(length, width);
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }

            //Testcase 3 for GetLength()
            [Test]
            public void GetLength_InputLength15_Width20()
            {
                //Arrange
                int length = 15;
                int width = 20;
                int expectedLength = length;

                //Act
                rectangle = new Rectangle(length, width);
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }

            //Testcase 4 for SetLength()
            [Test]
            public void SetLength_InputLength15_Width25()
            {
                //Arrange
                int length = 15;
                int width = 25;
                int expectedLength = length;

                //Act
                rectangle = new Rectangle(length, width);
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }

            //Testcase 5 for SetLength()
            [Test]
            public void SetLength_InputLength30_Width20()
            {
                //Arrange
                int length = 30;
                int width = 20;
                int expectedLength = length;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }

            //Testcase 6 for SetLength()
            [Test]
            public void SetLength_InputLength25_Width25()
            {
                //Arrange
                int length = 25;
                int width = 25;
                int expectedLength = length;

                //Act
                rectangle = new Rectangle(length, width);
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(actualLength, expectedLength);
            }

            //Testcase 7 for GetWidth()
            [Test]
            public void GetWidth_InputLength10_Width10()
            {
                //Arrange
                int length = 10;
                int width = 10;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }

            //Testcase 8 for GetWidth()
            [Test]
            public void GetWidth_InputLength25_Width40()
            {
                //Arrange
                int length = 25;
                int width = 40;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }
            //Testcase 9 for GetWidth()
            [Test]
            public void GetWidth_InputLength45_Width10()
            {
                //Arrange
                int length = 45;
                int width = 10;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }

            //Testcase 10 for SetWidth()
            [Test]
            public void SetWidth_InputLength90_Width30()
            {
                //Arrange
                int length = 90;
                int width = 30;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }
            //Testcase 11 for SetWidth()
            [Test]
            public void SetWidth_InputLength25_Width30()
            {
                //Arrange
                int length = 25;
                int width = 30;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }
            //Testcase 12 for SetWidth()
            [Test]
            public void SetWidth_InputLength6_Width35()
            {
                //Arrange
                int length = 6;
                int width = 35;
                int expectedWidth = width;

                //Act
                rectangle = new Rectangle(length, width);
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(actualWidth, expectedWidth);
            }

            //Testcase 13 for GetPerimeter()
            [Test]
            public void GetPerimeter_InputLength14_Width12()
            {
                //Arrange
                int length = 14;
                int width = 12;
                int expectedPerimeter = 52;


                //Act
                rectangle = new Rectangle(length, width);
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(actualPerimeter, expectedPerimeter);
            }

            //Testcase 14 for GetPerimeter
            [Test]
            public void GetPerimeter_InputLength8_Width12()
            {
                //Arrange
                int length = 8;
                int width = 12;
                int expectedPerimeter = 40;

                //Act
                rectangle = new Rectangle(length, width);
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(actualPerimeter, expectedPerimeter);
            }

            //Testcase 15 for GetPerimeter
            [Test]
            public void GetPerimeter_InputLength5_Width15()
            {
                //Arrange
                int length = 5;
                int width = 15;
                int expectedPerimeter = 40;

                //Act
                rectangle = new Rectangle(length, width);
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(actualPerimeter, expectedPerimeter);
            }

            //Testcase 16 for GetArea
            [Test]
            public void GetArea_InputLength12_Width12()
            {
                //Arrange
                int length = 12;
                int width = 12;
                int expectedArea = 144;

                //Act
                rectangle = new Rectangle(length, width);
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(actualArea, expectedArea);
            }

            //Testcase 17 for GetArea
            [Test]
            public void GetArea_InputLength5_Width5()
            {
                //Arrange
                int length = 5;
                int width = 5;
                int expectedArea = 25;

                //Act
                rectangle = new Rectangle(length, width);
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(actualArea, expectedArea);
            }

            //Testcase 18 for GetArea
            [Test]
            public void GetArea_InputLength15_Width15()
            {
                //Arrange
                int length = 15;
                int width = 15;
                int expectedArea = 225;

                //Act
                rectangle = new Rectangle(length, width);
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(actualArea, expectedArea);
            }
        }
    
}
