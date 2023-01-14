using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Student : Human
    {
        #region Fields
        string facultyNumber;
        #endregion

        #region Constructor
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        #endregion

        #region Properties
        public string FacultyNumber
        {
            get { return facultyNumber; }
            set 
            { 
                if(value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value; 
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
        #endregion
    }
}
