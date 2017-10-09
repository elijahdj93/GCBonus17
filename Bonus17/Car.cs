using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }


        public Car()
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }

        public Car(string clientMake, string clientModel, int clientYear, double clientPrice)
        {
            make = clientMake;
            model = clientModel;
            year = clientYear;
            price = clientPrice;
        }
    }
}
