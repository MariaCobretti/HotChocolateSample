﻿using System;
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
    public partial class BasicInventoryResultParser
        : JsonResultParserBase<IBasicInventory>
    {
        private readonly IValueSerializer _uuidSerializer;
        private readonly IValueSerializer _stringSerializer;

        public BasicInventoryResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _uuidSerializer = serializerResolver.Get("Uuid");
            _stringSerializer = serializerResolver.Get("String");
        }

        protected override IBasicInventory ParserData(JsonElement data)
        {
            return new BasicInventory1
            (
                ParseBasicInventoryBasicInventory(data, "basicInventory")
            );

        }

        private global::BerryClient.IBasicInventoryConnection ParseBasicInventoryBasicInventory(
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

            return new BasicInventoryConnection
            (
                ParseBasicInventoryBasicInventoryNodes(obj, "nodes")
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory1> ParseBasicInventoryBasicInventoryNodes(
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
            var list = new global::BerryClient.IBasicInventory1[objLength];
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
    }
}
