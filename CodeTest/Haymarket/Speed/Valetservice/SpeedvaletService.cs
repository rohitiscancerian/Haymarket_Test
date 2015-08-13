using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.Factory;
using CodeTest.Haymarket.abstractions;
using CodeTest.OtherCompany.Classification;

namespace CodeTest.Haymarket.Speed.Valetservice
{
    public class SpeedvaletService : IValetingQuoteService
    {
        public string RequestAQuote(string serviceType, string model)
        {
            double quotePrice = 0;
            string vehicleType = string.Empty;
            ClassifyModel objClassifyModel = new ClassifyModel();
            CarModelFactory objCarModelFactory = new CarModelFactory();
            
            try 
            {
                // The below call to the Other company service will return the type of the car based on the model
                vehicleType = objClassifyModel.GetCarType(model);
                if ( vehicleType != string.Empty)
                {
                    CarModel objCarModel = objCarModelFactory.GetCarModel(vehicleType);
                    ServiceTypeFactory objServiceTypeFactory = new ServiceTypeFactory();
                    ServiceType objServiceType = objServiceTypeFactory.GetServiceType(serviceType);

                    // Followiing code will set the Listed price of the service for the respective model
                    objServiceType.getListedPrice(objCarModel);

                    // Following code will return the discounted price if applicable defined in the abstract service type class
                    quotePrice = objServiceType.getDiscountedPrice(objCarModel);

                }
                else
                {
                    new ServiceUnAvailableException();
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return "£" + string.Format("{0:N2}", quotePrice) ;
        }
    }
}
