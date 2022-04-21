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
            IDocument Document;
            string SprintString = _sprint.ToString();
            switch (_documentType)
            {
                case DocumentType.Docx:
                    Document = new DocxAdapter(new WordAPI(SprintString));
                    break;
                case DocumentType.PDF:
                    Document = new DocxAdapter(new WordAPI(SprintString));
                    break;
                default:
                    return false;
                    break;
            }
            return Document.Export();
        }
    }
}
