#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class VariantSerializer
        : global::StrawberryShake.Serialization.IInputValueFormatter
        , global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Variant>
    {
        public global::System.String TypeName => "Variant";

        public Variant Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "DEFAULT" => Variant.Default,
                "TIME_SERIES" => Variant.TimeSeries,
                "TIME_SERIES_GROUP" => Variant.TimeSeriesGroup,
                "VIRTUAL_TIME_SERIES" => Variant.VirtualTimeSeries,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
                Variant.Default => "DEFAULT",
                Variant.TimeSeries => "TIME_SERIES",
                Variant.TimeSeriesGroup => "TIME_SERIES_GROUP",
                Variant.VirtualTimeSeries => "VIRTUAL_TIME_SERIES",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}
