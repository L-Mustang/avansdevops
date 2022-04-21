using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class WordAPI : IDocx
    {
        private string _rawText;
        
        public WordAPI(string rawText)
        {
            _rawText = rawText;
        }

        public string RawText
        {
            get { return _rawText; }
            set { _rawText = value; }
        }

        public bool ExportToDocx()
        {
            Console.Out.WriteLine("Docx:");
            Console.Out.WriteLine(_rawText);
            return true;
        }
    }
}
