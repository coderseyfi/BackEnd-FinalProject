using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Domain.AppCode.Infracture
{
    public abstract class PaginateModel
    {
        int pageIndex;
        int pageSize;

        public int PageIndex
        {
            get
            {
                return this.pageIndex < 1 ? 1 : this.pageIndex;
            }
            set
            {
                if (value >= 1)
                {
                    pageIndex = value;
                }
            }
        }
        public virtual int PageSize
        {
            get
            {
                return this.pageSize < 5 ? 5 : this.pageSize;

            }
            set
            {
                if (value >= 5)
                {
                    pageSize = value;
                }
            }
        }
    }
}