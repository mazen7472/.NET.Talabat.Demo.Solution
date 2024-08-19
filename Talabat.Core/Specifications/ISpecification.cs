using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Specifications
{
    public interface ISpecification<T>
    {
        //Prop For Where Condition
        public Expression<Func<T, bool>> Criteria { get; set; }

        //Prop For List Of Includes
        public List<Expression<Func<T, object>>> Includes { get; set; }

        //Prop For OrderBy
        public Expression<Func<T , object>> OrderBy { get; set; }

        //Prop For OrderByDescending
        public Expression<Func<T, object>> OrderByDescending { get; set; }


        public int Take { get; set; }
        public int Skip { get; set; }
        public bool IsPaginationEnabled { get; set; }
    }
}
