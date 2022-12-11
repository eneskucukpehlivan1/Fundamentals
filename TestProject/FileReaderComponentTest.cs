using Moq;
using UnitTestExample;

namespace TestProject
{
    public class FileReaderComponentTest
    {
        [Fact]
        public void ReadAndAppendHello_ExistingPathGiven_ReturnContentWithHello()
        {
            //var path = "/Users/eneskucukpehlivan/Desktop/test.txt";
            //var file = File.CreateText(path);
            //file.Write("Deneme");
            //file.Close();
            //var fileReaderComponent = new FileReaderComponent();
            //var content = fileReaderComponent.ReadAndAppendHello(path);
            //Assert.Equal("DenemeHello", content);

            var path = "/Users/eneskucukpehlivan/Desktop/test.txt";
            var fileReaderComponent = new FileReaderComponent(new FileReaderStub());
            var content = fileReaderComponent.ReadAndAppendHello(path);
            Assert.Equal("DenemeHello", content);
        }

        [Fact]
        public void ReadAndAppendHello_NonExistingPathGiven_ThrowException()
        {

            var path = "nonexisting.txt";
            var fileReaderComponent = new FileReaderComponent(new FileReaderStubFalse());
            Assert.Throws<ArgumentException>(() => fileReaderComponent.ReadAndAppendHello(path));
        }

        [Fact]
        public void ReadAndAppendHello_ExistingPathGiven_ReturnContentWithHelloWithMoq()
        {
            var path = "/Users/eneskucukpehlivan/Desktop/test.txt";
            var fileReaderMock = new Mock<IFileReader>();
            //fileReaderMock.Setup(x => x.Exists(path)).Returns(true);
            //fileReaderMock.Setup(x => x.ReadAllText(path)).Returns("Deneme");
            fileReaderMock.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
            fileReaderMock.Setup(x => x.ReadAllText(It.IsAny<string>())).Returns("Deneme");
            var fileReaderComponent = new FileReaderComponent(fileReaderMock.Object);
            var content = fileReaderComponent.ReadAndAppendHello(path);
            Assert.Equal("DenemeHello", content);

        }

    }

    class FileReaderStub : IFileReader
    {
        public bool Exists(string path)
        {
            return true;
        }

        public string ReadAllText(string path)
        {
            return "Deneme";
        }
    }
    class FileReaderStubFalse : IFileReader
    {
        public bool Exists(string path)
        {
            return false;
        }

        public string ReadAllText(string path)
        {
            return "Deneme";
        }
    }
}