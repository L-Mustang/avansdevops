using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class PDFAdapter : IDocument
    {
        private readonly IPDF _pdf;

        public PDFAdapter(IPDF pdf)
        {
            _pdf = pdf;
        }

        public string Text
        {
            get { return _pdf.FormattedText; }
            set { _pdf.FormattedText = value; }
        }

        public bool Export()
        {
            if (_pdf.FormattedText.Equals("Success"))
                return true;
            else return false;
        }
    }
}
