using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;

namespace CodeTest.Haymarket.Models
{
    class GoldServiceType  : ServiceType
    {
        private const double type_A_price = 119.99;
        private const double type_B_price = 123.99;
        private const double type_C_price = 130.99;

        public GoldServiceType()
        {
            Type = "GOLD";
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
