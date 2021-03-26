using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace HC.Server._11_1
{
    public class MutationType : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Mutation");

            descriptor.Field("CreateWithComplexArg")
                .Argument("input", x => x.Type<ComplexInputType>())
                //.Type<StringType>()
                .Type<ComplexOutputType>()
                .Resolve(x =>
                {
                    var args = x.ArgumentValue<ComplexInput>("input");
                    Console.WriteLine("hit");
                    return new ComplexOutput()
                    {
                        NumberField = args.NumberField,
                        StringField = args.StringField
                    };
                    //return args.StringField;
                });
        }
    }

    class ComplexInputType : InputObjectType<ComplexInput>
    {
        
    }
    class ComplexOutputType : ObjectType<ComplexOutput>
    {
        
    }
    public class ComplexInput
    {
        public string StringField { get; set; }
        public double NumberField { get; set; }
    }
    public class ComplexOutput
    {
        public string StringField { get; set; }
        public double NumberField { get; set; }
    }
}
