using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class FileReaderComponent
    {
        private readonly IFileReader _fileReader;
        public FileReaderComponent(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }
        public string ReadAndAppendHello(string path)
        {
            //if (File.Exists(path))
            //{
            //	var content = File.ReadAllText(path);
            //	return content + "Hello";
            //}
            if (_fileReader.Exists(path))
            {
                var content = _fileReader.ReadAllText(path);
                return content + "Hello";
            }
            throw new ArgumentException($"{nameof(path)} is invalid!");
        }
    }


    public interface IFileReader
    {
        bool Exists(string path);
        string ReadAllText(string path);
    }

    public class FileReader : IFileReader
    {
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }

}
