﻿#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the CreateBasicInventory2 GraphQL operation
    /// <code>
    /// mutation CreateBasicInventory2($input: [CreateBasicInventoryInput!]!) {
    ///   createBasicInventory(input: $input) {
    ///     __typename
    ///     concreteItems {
    ///       __typename
    ///       ... BasicInventory
    ///       ... on BasicInventory {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment BasicInventory on BasicInventory {
    ///   dynamicItemId
    ///   numberField
    ///   stringField
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2MutationDocument
        : global::StrawberryShake.IDocument
    {
        private CreateBasicInventory2MutationDocument()
        {
        }

        public static CreateBasicInventory2MutationDocument Instance { get; } = new CreateBasicInventory2MutationDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Mutation;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x6d, 0x75, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x32, 0x28, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x5b, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x5d, 0x21, 0x29, 0x20, 0x7b, 0x0d, 0x0a, 0x20, 0x20, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x28, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x29, 0x20, 0x7b, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x63, 0x6f, 0x6e, 0x63, 0x72, 0x65, 0x74, 0x65, 0x49, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x20, 0x7b, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x69, 0x64, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x7d, 0x0d, 0x0a, 0x20, 0x20, 0x20, 0x20, 0x7d, 0x0d, 0x0a, 0x20, 0x20, 0x7d, 0x0d, 0x0a, 0x7d, 0x0d, 0x0a, 0x0d, 0x0a, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x20, 0x6f, 0x6e, 0x20, 0x42, 0x61, 0x73, 0x69, 0x63, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x20, 0x7b, 0x0d, 0x0a, 0x20, 0x20, 0x64, 0x79, 0x6e, 0x61, 0x6d, 0x69, 0x63, 0x49, 0x74, 0x65, 0x6d, 0x49, 0x64, 0x0d, 0x0a, 0x20, 0x20, 0x6e, 0x75, 0x6d, 0x62, 0x65, 0x72, 0x46, 0x69, 0x65, 0x6c, 0x64, 0x0d, 0x0a, 0x20, 0x20, 0x73, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x46, 0x69, 0x65, 0x6c, 0x64, 0x0d, 0x0a, 0x7d };

        public override global::System.String ToString()
        {
            return global::System.Text.Encoding.UTF8.GetString(Body);
        }
    }
}
