using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;

namespace CodeTest.Haymarket.Models
{
    class TypeBModel : CarModel
    {
        public TypeBModel()
        { Model = "TYPE_B"; }

        public override string getModel()
        {
            return Model;
        }
    }
}
