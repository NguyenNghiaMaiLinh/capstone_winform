using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys.model
{
    public class PagingModel<T>
    {
        public ICollection<T> Data { get; set; }
        public int Total { get; set; }
    }
}
