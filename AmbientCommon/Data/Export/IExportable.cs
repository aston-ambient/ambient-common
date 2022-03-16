using System;
using System.Collections.Generic;
using System.Text;

namespace AmbientCommon.Data.Export
{
    public interface IExportable
    {
        string GetCSVHeaders();
        string GetAsCSVRow(bool enumAsName);
        string GetAsJSONItem();
    }
}
