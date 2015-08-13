using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.Haymarket.abstractions;

namespace CodeTest.Haymarket.Models
{
    class TypeAModel : CarModel
    {
        public TypeAModel()
        { Model = "TYPE_A"; }

        public override string getModel()
        {
            return Model;
        }
    }
}
