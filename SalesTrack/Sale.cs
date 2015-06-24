using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTrack
{    //Created by Trenton Thompson
public class Sale
    { //This is the Sale class where I encapsulate and assign values to my properties or fields.
    //By using private I'm able to create a black box here or in other words encapsulate these fields in my class.
       private string code;
       private string description;
       private decimal price;
    //Below I have created an empty constructor for Sale class and this creates an instance of the Sale class, initializes the fields to default values.
       public Sale(){}
    //Below I have created a custom constructor that creates an instance of the class and initializes values that are passed into the three field parameters.
       public Sale(string code, string description, decimal price)
       {
           this.Code = code;
           this.Description = description;
           this.Price = price;
    }
    //Below I have 3 properties known as Code, Description and Price, where the values are applied through get and set.
       public string Code
         {
             get
              {
                  return code;
              }
             set
              {
                  code = value;
              }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    ////Below is a method that has a string value called sep as a parameter.
 //// this method returns a string that concatenates (or joins two or more strings) the 3 fields separated by the value passed via the sep parameter.
    
        public string GetDisplayText(string sep)
        {
            return code + sep + price.ToString("c") + sep + description;
        }
    }
}

    

