using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;

namespace CodeTest.Haymarket.Models
{
    class SilverServiceType :  ServiceType
    {

        private const double type_A_price = 89.99;
        private const double type_B_price = 93.99;
        private const double type_C_price = 100.99;

        public SilverServiceType()
        {
            Type = "SILVER";
        }

        public override string getType()
        {
            return Type;
        }

        public override double getListedPrice(CarModel objCarModel)
        {
            switch (objCarModel.getModel())
            {
                case "TYPE_A":
                    Price = type_A_price;
                    break;
                case "TYPE_B":
                    Price = type_B_price;
                    break;
                case "TYPE_C":
                    Price = type_C_price;
                    break;
                default: break;
            }
            return Price;
        }
    }
    
}
