using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Person
    {
        #region Fields

        protected string name;
        protected int age;

        #endregion

        #region Constructor

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        #endregion

        #region Properties

        public virtual string Name
        {
            get { return name; }
            set 
            { 
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                name = value; 
            }
        }

        public virtual int Age
        {
            get { return age; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                age = value; 
            }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return stringBuilder.ToString();
        }

        #endregion
    }
}
