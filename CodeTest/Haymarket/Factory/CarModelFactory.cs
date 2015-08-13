using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;
using CodeTest.Haymarket.Models;

namespace CodeTest.Haymarket.Factory
{
    class CarModelFactory
    {
        // This class is given the responsibility of returning object of the appropriate Car model
        public CarModel GetCarModel(string model)
        {
            CarModel objCarModel = null;
            switch (model.ToUpper())
            {
                case "TYPE_A": objCarModel = new TypeAModel();
                    break;
                case "TYPE_B": objCarModel = new TypeBModel();
                    break;
                case "TYPE_C": objCarModel = new TypeCModel();
                    break;
            }
            return objCarModel;
        }
    }
}
