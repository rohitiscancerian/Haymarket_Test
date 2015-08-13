using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeTest.Haymarket.abstractions
{
    public abstract  class ServiceType
    {
        private double price;

        private string type;

        public double Price { get { return price; } set { price = value; } }

        public string Type { get { return type; } set { type = value; } }

        public virtual string getType()
        {
            return Type;
        }

        public virtual double getListedPrice(CarModel objCarModel)
        {
            return Price;
        }
        
        public double getDiscountedPrice(CarModel objCarModel)
        {
            switch(objCarModel.getModel())
            {
                case "TYPE_C": 
                  Price =  0.9 * Price;
                    break;
                default :
                    break;

            }
            return Price;
        }
    }
}
