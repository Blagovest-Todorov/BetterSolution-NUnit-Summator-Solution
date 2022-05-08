using NUnit.Framework;
using System;
using System.Linq;

namespace Summator.Tests
{
    public class Tests
    {
        private Summator summator;       

        [OneTimeSetUp]     
        public void OneTimeSetUp()
        {           
            Console.WriteLine("All Test Started" + DateTime.Now);
        }

        [SetUp]
        public void SetUp() 
        {
            summator = new Summator();
            Console.WriteLine("Test Started" + DateTime.Now);
        }

        [Test]
        public void Test_Sum_TwoPosiotiveNumbers()
        {
            double actual = summator.Sum(new double[]{ 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        [Category("Critical")]
        public void Test_Sum_MultiplePositiveNumbers()
        {
            double actual = summator.Sum(new double[] { 5, 7, 8, 9, 10 });
            int expected = 39;

            Assert.That(expected == actual);
        }


        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            double actual = summator.Sum(new double[] { 5 });
            Assert.That(5 == actual);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            double actual = summator.Sum(new double[] { -7, -9 });

            Assert.That(-16 == actual);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            double actual = summator.Sum(new double[] { });
           
            Assert.That(0 == actual);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            double actual = summator.Sum(new double[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPosiotiveNumbersWithEvenSum()
        {
            double expected = Summator.Average(new double[] { 5, 7 });
            int actual = 6;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Average_TwoPosiotiveNumbersWithOddSum()
        {
            double expected = Summator.Average(new double[] { 5, 8 });
            double actual = 6.5;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_TwoPositiveNumbersAAA() 
        {
            //Arrange
            var values = new double[] {5,7};
            long expected = 12;

            // Act -> sum the values from the long array passed

            double actual = summator.Sum(values);


            // Assert ->  verify the values, chec k the valies
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Assertions() 
        {
            // Arrange -> prepare the input data
            var values = new double[]{ 5, 7 };
            long expected = 12;

            // Act
            double actual = summator.Sum(values);
            Assert.That(expected == actual, "Summator value should be equal to 12"); // first way
            Assert.That(expected, Is.EqualTo(actual)); //secWay
            Assert.AreEqual(expected, actual); //thirdWay

            double percentage = 99.95;
            Assert.That( percentage, Is.InRange(80, 100)); //This is rangeAssesment

            Assert.That("QAs are awesome", Does.Contain("awesome"));

            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            Assert.That(() => "abv"[10], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(Enumerable.Range(1, 100), Has.Member(50));

            //var percentages = new long[] {10, 30, 50, 99 };
            //Assert.That( percentage, Is.All.InRange(0, 100));

            var names = new[] { "Sarah", "Amrit", "Amanda", "Sarah", "arah"};
            Assert.That(names, Has.Exactly(5).Items);

            //Assert.That(names, Is.Unique);
            Assert.That(names, Is.Not.Empty);
            Assert.That(names, Contains.Item("Sarah"));
            Assert.That(names, Has.Exactly(2).EqualTo("Sarah"));
            Assert.That(names, Has.Exactly(1).Matches<string>(name => name.Contains("mri")));

            var fileExists = @"C:\filePath.txt";
            Assert.That(fileExists, Does.Exist);
        }
        

        [TearDown]
        public void TearDown()
        {
            summator = null;
            Console.WriteLine("Test end:" + DateTime.Now);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {            
            Console.WriteLine("All Tests end:" + DateTime.Now);
        }

    }
}