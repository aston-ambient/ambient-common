using System;
using System.Collections.Generic;
using System.Text;

namespace ambient_common.Data.Export
{
    public interface IExportable<T>
    {
        string GetCSVHeaders();
        string GetAsCSVRow(bool enumAsName);
        string GetAsJSONItem();
    }
}
