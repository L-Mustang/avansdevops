using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class DocxAdapter : IDocument
    {
        private readonly IDocx _docx;

        public DocxAdapter(IDocx docx)
        {
            _docx = docx;
        }

        public string Text
        {
            get { return _docx.RawText; }
            set { _docx.RawText = value; }
        }

        public bool Export()
        {
            return _docx.ExportToDocx()
        }
    }
}
