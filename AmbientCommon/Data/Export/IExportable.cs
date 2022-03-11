using System;
using System.Collections.Generic;
using System.Text;

namespace AmbientCommon.Data.Export
{
    public interface IExportable<T>
    {
        string GetCSVHeaders();
        string GetAsCSVRow(bool enumAsName);
        string GetAsJSONItem();
    }
}
