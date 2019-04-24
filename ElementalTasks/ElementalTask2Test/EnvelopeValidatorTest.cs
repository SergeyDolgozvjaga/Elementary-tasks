using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask2;

namespace ElementalTask2Test
{
    [TestClass]
    public class EnvelopeValidatorTest
    {

        [TestMethod]
        public void IsContinue_ValidTest()
        {
            bool expected = true;
            bool actual;

            actual = EnvelopeValidator.IsContinue("yes");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(true, "Yes")]
        [DataRow(true, "yeS")]
        [DataRow(true, "YEs")]
        [DataRow(true, "YES")]
        public void IsContinueValidTest(bool expected, string input)
        {
            bool actual;

            actual = EnvelopeValidator.IsContinue(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsContinue_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = EnvelopeValidator.IsContinue("no");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(false, "No")]
        [DataRow(false, "n")]
        [DataRow(false, "z")]
        [DataRow(false, " ")]
        public void IsContinueInvalidTest(bool expected, string input)
        {
            bool actual;

            actual = EnvelopeValidator.IsContinue(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidEnvelope_5_6_ValidTest()
        {
            bool expected = true;
            bool actual;

            Envelope envelope = new Envelope(5, 6);
            actual = EnvelopeValidator.IsValidEnvelop(envelope);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(true, 4, 9)]
        [DataRow(true, 15, 3)]
        [DataRow(true, 100, 300)]
        [DataRow(true, 2000, 4000)]
        [DataRow(true, 5000, 5000)]
        public void IsValidEnvelopeValidTest(bool expected, double width, double heigth)
        {
            bool actual;

            Envelope envelope = new Envelope(width, heigth);
            actual = EnvelopeValidator.IsValidEnvelop(envelope);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidEnvelope_0_6_InvalidTest()
        {
            bool expected = false;
            bool actual;

            Envelope envelope = new Envelope(0, 6);
            actual = EnvelopeValidator.IsValidEnvelop(envelope);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(false, 0, 9)]
        [DataRow(false, 15, -3)]
        [DataRow(false, 10000, 300)]
        [DataRow(false, 7000, 4000)]
        [DataRow(false, 50, -20000)]
        public void IsValidEnvelopeInvalidTest(bool expected, double width, double heigth)
        {
            bool actual;

            Envelope envelope = new Envelope(width, heigth);
            actual = EnvelopeValidator.IsValidEnvelop(envelope);

            Assert.AreEqual(expected, actual);
        }
    }
}
