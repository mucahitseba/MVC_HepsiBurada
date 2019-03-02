using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MODELS.Enums.Notebook
{
    public enum NotebookHarddisk
    {
        [Description("256 GB")]
        GB256,
        [Description("500 GB")]
        GB500,
        [Description("1 TB")]
        TB1,
        [Description("2 TB")]
        TB2
    }
}
