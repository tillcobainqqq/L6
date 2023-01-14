using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Human
    {
        #region Fields
        protected string firstName;
        protected string lastName;
        #endregion

        #region Constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        #endregion

        #region Propeties
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                char[] chars = value.ToCharArray();
                if(!char.IsUpper(chars[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if(value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                char[] chars = value.ToCharArray();
                if (!char.IsUpper(chars[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: firstName");
                }

                lastName = value;
            }
        }
        #endregion
    }
}
