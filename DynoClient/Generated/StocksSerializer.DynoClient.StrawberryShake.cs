#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class StocksSerializer
        : global::StrawberryShake.Serialization.IInputValueFormatter
        , global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Stocks>
    {
        public global::System.String TypeName => "Stocks";

        public Stocks Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "NA" => Stocks.Na,
                "TSLA" => Stocks.Tsla,
                "GME" => Stocks.Gme,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
                Stocks.Na => "NA",
                Stocks.Tsla => "TSLA",
                Stocks.Gme => "GME",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}
