using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.OtherCompany.Classification
{
    class ClassifyModel : ICarClassificationService
    {

        public string GetCarType(string model)
        {
            string modelType = string.Empty;
            switch(model.ToUpper())
            {
                case "SMALL" :  modelType = "TYPE_A";
                    break;
                case "FAMILY": modelType = "TYPE_A";
                    break;
                case "MINI": modelType = "TYPE_A";
                    break;
                case "SALOON": modelType = "TYPE_B";
                    break;
                case "EXECUTIVE": modelType = "TYPE_B";
                    break;
                case "MPV": modelType = "TYPE_C";
                    break;
                case "4X4": modelType = "TYPE_C";
                    break;
                default :
                    new UnknownTypeException();
                    break;

            }
            return modelType;
        }
    }
}
