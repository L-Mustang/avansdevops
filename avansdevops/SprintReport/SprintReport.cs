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
        private IDocument _documentAdapter;

        public SprintReport(Sprint sprint, IDocument documentAdapter)
        {
            _sprint = sprint;
            _documentAdapter = documentAdapter;
        }

        public bool createReportDocument()
        {
            _documentAdapter.Text = _sprint.ToString();
            return _documentAdapter.Export();
        }
    }
}
