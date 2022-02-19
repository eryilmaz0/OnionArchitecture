using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Wrapper
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PagedResponse(T value, int pageSize, int pageNumber) : base(value)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
