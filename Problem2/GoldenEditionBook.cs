using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class GoldenEditionBook : Book
    {
        #region Constructor
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }
        #endregion

        #region Properties
        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
        }

        #endregion
    }
}
