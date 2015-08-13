using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;

namespace CodeTest.Haymarket.Models
{
    public class BronzeServiceType : ServiceType
    {
        private const double type_A_price = 79.99;
        private const double type_B_price = 83.99;
        private const double type_C_price = 90.99;
        
        public BronzeServiceType()
        {
            Type = "BRONZE";
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
