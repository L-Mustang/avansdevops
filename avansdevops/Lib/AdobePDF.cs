using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class AdobePDF : IPDF
    {
        private string _formattedText;

        public AdobePDF(string formattedText)
        {
            _formattedText = formattedText;
        }

        public string FormattedText
        {
            get { return _formattedText; }
            set { _formattedText = value; }
        }

        public string ExportToPDF()
        {
            Console.Out.WriteLine("PDF:");
            Console.Out.WriteLine(_formattedText);
            return "Success";
        }
    }
}
