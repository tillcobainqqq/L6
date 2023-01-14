using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Book
    {
        #region Fields
        protected string author;
        protected string title;
        protected decimal price;
        #endregion

        #region Constructor
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        #endregion

        #region Properties
        public string Author
        {
            get { return author; }
            set 
            { 
                char[] arr = value.ToCharArray();
                char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                for(int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++) 
                    {
                        if (arr[i] == ' ' && arr[i + 1] == numbers[j])
                        {
                            throw new ArgumentException("Author not valid!");
                        }
                    }
                }
                author = value;
            }
        }

        public string Title
        {
            get { return title; }
            set 
            { 
                if(value.Length < 3)
                {
                    throw new ArgumentException("Title not valid");
                }
                title = value; 
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Price not valid");
                }
                price = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
        #endregion
    }
}
