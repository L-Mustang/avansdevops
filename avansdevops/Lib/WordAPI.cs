using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class WordAPI
    {
        private string _extension;
        
        public WordAPI(string extension)
        {
            _extension = extension;
        }

        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        public void SaveDocx(string fileName, string text)
        {
            Console.Out.WriteLine("Saving to file: {0}.{1}", fileName, _extension);
            Console.Out.WriteLine(text);
        }
    }
}
