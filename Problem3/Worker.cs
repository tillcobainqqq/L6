using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Worker : Human
    {
        #region Fields
        double weekSalary;
        double workingHours;
        #endregion

        #region Constructor
        public Worker(string firstName, string lastName, double weekSalary, double workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }
        #endregion

        #region Properties
        public double WeekSalary
        {
            get { return weekSalary; }
            set 
            { 
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value; 
            }
        }

        public double WorkingHours
        {
            get { return workingHours; }
            set 
            { 
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workingHours = value; 
            }
        }

        public double SalaryPerHour
        {
            get { return weekSalary / workingHours; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week salary: {this.WeekSalary}")
            .AppendLine($"Working hours: {this.WorkingHours}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
        #endregion
    }
}
