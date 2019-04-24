using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask2;

namespace ElementalTask2Test
{
    [TestClass]
    public class EnvelopeCalculateTest
    {
        [TestMethod]
        public void Envelope1_Input_Envelope2_Check_Test()
        {
            string expected = "You can put Envelope1 in Envelope2";
            string actual;

            Envelope envelope1 = new Envelope(5, 7);
            Envelope envelope2 = new Envelope(10, 12);
            actual = new EnvelopeCalculation().EnvelopeCheck(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Envelope2_Input_Envelope1_Check_Test()
        {
            string expected = "You can put Envelope2 in Envelope1";
            string actual;

            Envelope envelope1 = new Envelope(12, 15);
            Envelope envelope2 = new Envelope(9, 13);
            actual = new EnvelopeCalculation().EnvelopeCheck(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Envelope2_Envelope1_Cannot_Put_Check_Test()
        {
            string expected = "You cannot put one envelope to another.";
            string actual;

            Envelope envelope1 = new Envelope(9, 4);
            Envelope envelope2 = new Envelope(5, 7);
            actual = new EnvelopeCalculation().EnvelopeCheck(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }


    }
}
