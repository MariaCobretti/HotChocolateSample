#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _floatFormatter = default!;

        public global::System.String TypeName => "CreateBasicInventoryInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _floatFormatter = serializerResolver.GetInputValueFormatter("Float");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (!(runtimeValue is CreateBasicInventoryInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "stringField",
                    FormatStringField(d.StringField)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "numberField",
                    FormatNumberField(d.NumberField))
            };
        }

        private global::System.Object? FormatStringField(global::System.String? value)
        {
            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatNumberField(global::System.Double? value)
        {
            return _floatFormatter.Format(value);
        }
    }
}
