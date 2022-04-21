using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class SprintReport
    {
        private string _sprint;
        private DocumentType _documentType;
        //TODO Add sprints

        public SprintReport(string sprint, DocumentType documentType)
        {
            _sprint = sprint;
            _documentType = documentType;
        }

        public bool createReportDocument()
        {
            switch (_documentType)
            {
                case DocumentType.Docx:
                    return true;
                case DocumentType.PDF:
                    return true;
                default:
                    return false;
            }
        }
    }
}
