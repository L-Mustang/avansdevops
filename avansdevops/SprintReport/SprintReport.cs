using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class SprintReport
    {
        private Sprint _sprint;
        private DocumentType _documentType;

        public SprintReport(Sprint sprint, DocumentType documentType)
        {
            _sprint = sprint;
            _documentType = documentType;
        }

        public bool createReportDocument()
        {
            IDocument document;
            string sprintString = _sprint.ToString();
            switch (_documentType)
            {
                case DocumentType.Docx:
                    document = new DocxAdapter(new WordAPI(sprintString));
                    break;
                case DocumentType.PDF:
                    document = new PDFAdapter(new AdobePDF(sprintString));
                    break;
                default:
                    return false;
            }
            return document.Export();
        }
    }
}
