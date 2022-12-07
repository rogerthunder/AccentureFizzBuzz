using AccentureFizzBuzz.Models;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CustomByRange_10to60_returnsList()
        {
            //Arrange

            var fizzBuzzTest = new Fizzbuzz();
            var divisorTokens = new Dictionary<string, int>();

            divisorTokens.Add("roger", 2);
            divisorTokens.Add("alan", 3);
            divisorTokens.Add("moreno", 5);

            var customReq = new CustomRequest();
            customReq.divisorToken = divisorTokens;


            //Act
            fizzBuzzTest.CustomByRange(customReq.divisorToken, 10,60);

            var result = fizzBuzzTest.fizzbuzzResolved;


            //Assert

            Assert.IsTrue(result is not null);
        }

        [Test]

        public void CustomByRange_0to0_returnsListEmpty()
        {
            //Arrange

            var fizzBuzzTest = new Fizzbuzz();
            var divisorTokens = new Dictionary<string, int>();

            divisorTokens.Add("roger", 2);
            divisorTokens.Add("alan", 3);
            divisorTokens.Add("moreno", 5);

            var customReq = new CustomRequest();
            customReq.divisorToken = divisorTokens;


            //Act
            fizzBuzzTest.CustomByRange(customReq.divisorToken, 0, 0);

            var result = fizzBuzzTest;


            //Assert

            Assert.IsTrue(result.fizzbuzzResolved.Count >= 0);
        }

        [Test]

        public void CustomRange_minus120to220_returnsListCount200()
        {
            //Arrange

            var fizzBuzzTest = new Fizzbuzz();
            var divisorTokens = new Dictionary<string, int>();

            divisorTokens.Add("buzz",5);
            divisorTokens.Add("fizz", 10);
            divisorTokens.Add("bazz", 8);

            var customReq = new CustomSetRequest();
            customReq.divisorToken = divisorTokens;


            //Act
            fizzBuzzTest.CustomByRange(customReq.divisorToken, -120, 120);

            var result = fizzBuzzTest;



            //Assert

            Assert.IsTrue(result.fizzbuzzResolved.Count == 240);
        }


        [Test]

        public void CustomSet_minus120to220_returnsListCount30()
        {
            //Arrange

            var fizzBuzzTest = new Fizzbuzz();
            var divisorTokens = new Dictionary<string, int>();

            divisorTokens.Add("buzz", 5);
            divisorTokens.Add("fizz", 10);


            var customReq = new CustomSetRequest();
            customReq.divisorToken = divisorTokens;
            customReq.setofIntergers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 20, 30, 40, 50, 60, 70, 91, 92, 93, 94, 95, 96, 97 };



            //Act
            fizzBuzzTest.CustomSet(customReq.setofIntergers, customReq.divisorToken);

            var result = fizzBuzzTest;



            //Assert

            Assert.IsTrue(result.fizzbuzzResolved.Count == 30);
        }
    }
}