using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryResultParser
        : JsonResultParserBase<ICreateBasicInventory>
    {
        private readonly IValueSerializer _uuidSerializer;
        private readonly IValueSerializer _stringSerializer;

        public CreateBasicInventoryResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _uuidSerializer = serializerResolver.Get("Uuid");
            _stringSerializer = serializerResolver.Get("String");
        }

        protected override ICreateBasicInventory ParserData(JsonElement data)
        {
            return new CreateBasicInventory1
            (
                ParseCreateBasicInventoryCreateBasicInventory(data, "createBasicInventory")
            );

        }

        private global::BerryClient.ICreateBasicInventoryPayload ParseCreateBasicInventoryCreateBasicInventory(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            return new CreateBasicInventoryPayload
            (
                ParseCreateBasicInventoryCreateBasicInventoryConcreteItems(obj, "concreteItems"),
                ParseCreateBasicInventoryCreateBasicInventoryErrors(obj, "errors")
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> ParseCreateBasicInventoryCreateBasicInventoryConcreteItems(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new global::BerryClient.IBasicInventory[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new BasicInventory
                (
                    DeserializeUuid(element, "dynamicItemId"),
                    DeserializeNullableString(element, "stringField")
                );

            }

            return list;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IUserError> ParseCreateBasicInventoryCreateBasicInventoryErrors(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new global::BerryClient.IUserError[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new UserError
                (
                    DeserializeString(element, "code"),
                    DeserializeString(element, "message")
                );

            }

            return list;
        }

        private System.Guid DeserializeUuid(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (System.Guid)_uuidSerializer.Deserialize(value.GetString());
        }

        private string DeserializeNullableString(JsonElement obj, string fieldName)
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string)_stringSerializer.Deserialize(value.GetString());
        }
        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
