using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;
using CodeTest.Haymarket.Models;

namespace CodeTest.Haymarket.Factory
{
    // This class is given the responsibility of returning object of the appropriate service type
    class ServiceTypeFactory
    {
        public ServiceType GetServiceType(string serviceType)
        {
            ServiceType objServiceType = null;
            switch (serviceType.ToUpper())
            {
                case "GOLD": objServiceType = new GoldServiceType();
                    break;
                case "SILVER": objServiceType = new SilverServiceType();
                    break;
                case "BRONZE": objServiceType = new BronzeServiceType();
                    break;
            }
            return objServiceType;
        }
    }
}
