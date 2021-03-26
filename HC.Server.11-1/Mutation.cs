using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HC.Server._11_1
{
    public class Mutation
    {
        public ComplexOutput CreateWithComplexArg(ComplexInput input)
        {
            return new ComplexOutput()
            {
                NumberField = input.NumberField,
                StringField = input.StringField
            };
        }
    }
}
