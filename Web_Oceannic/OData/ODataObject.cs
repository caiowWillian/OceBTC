using System.Collections.Generic;

namespace Web_Oceannic.OData
{
    public class ODataObject<T>
        where T : class
    {
        public IList<T> Value { get; set; }
    }
}
