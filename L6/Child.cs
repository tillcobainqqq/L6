using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Child : Person
    {
        #region Constructor
        public Child(string name, int age) : base(name, age)
        {
        }
        #endregion

        #region Properties
        public override string Name
        {
            get { return base.Name; }
            set 
            { 
                if(value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                base.Name = value; 
            }
        }

        public override int Age
        {
            get { return base.Age; }
            set
            {
                if(value < 0 || value > 15)
                {
                    throw new ArgumentException("Age must be positive and less than 15!");
                }
                base.Age = value;
            }
        }
        #endregion
    }
}
