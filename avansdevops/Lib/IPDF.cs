using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public interface IPDF
    {
        string FormattedText { get; set; }

        string ExportToPDF ();
    }
}
