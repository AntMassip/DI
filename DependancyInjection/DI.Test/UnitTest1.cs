using NUnit.Framework.Constraints;

namespace DI.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        //On test le Exclaim dans la class Salutation, on ne veut pas polluer notre test avec une implémentation de production
        public void ExclaimIMessageWriterTest()
        {
            var writer = new SpyMessageWriter();
            var sut = new Salutation(writer);
            sut.Exclaim();
            Assert.That(actual: writer.WrittenMessage, Is.EqualTo(expected: "Hello DI!"));
        }
    }

    public class SpyMessageWriter : IMessageWriter
    {
        public string WrittenMessage { get; private set; }
        public void Write(string message)
        {
            this.WrittenMessage += message;
        }
    }
}