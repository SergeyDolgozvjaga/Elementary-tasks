using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask2;

namespace ElementalTask2Test
{
    [TestClass]
    public class EnvelopeTest
    {
        [TestMethod]
        public void Envelope_Width_5_Check_Test()
        {
            double expected = 5;
            double actual;

            Envelope envelope = new Envelope(5, 7);
            actual = envelope.Width;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Envelope_Heigth_500_Check_Test()
        {
            double expected = 500;
            double actual;

            Envelope envelope = new Envelope(300, 500);
            actual = envelope.Heigth;

            Assert.AreEqual(expected, actual);
        }
    }
}
