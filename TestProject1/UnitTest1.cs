
using MoodAnalyaser_App;
using NUnit.Framework;


namespace TestProject1
{
    public class Tests
    {
        private MoodAnalyaser analyaser;

        [SetUp]

        public void Setup()
        {
             analyaser = new MoodAnalyaser("I am in Sad mood"));
        }

        [Test] 

        public void SadMessageReturnSAD()
        {
            string expecxted = "SAD";

            string mood= analyaser.AnalyseMood();

            Assert.AreEqual(expecxted, mood);
        }

        [Test]

        public void AnyMessageReturnHaapy()
        {
            string expecxted = "HAPPY";

            string mood = analyaser.AnalyseMood();

            Assert.AreEqual(expecxted, mood);
        }

    }
}