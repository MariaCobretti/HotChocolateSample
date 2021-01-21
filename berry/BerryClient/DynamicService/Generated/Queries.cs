using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            56,
            100,
            51,
            100,
            52,
            97,
            100,
            98,
            98,
            50,
            99,
            100,
            97,
            49,
            102,
            50,
            98,
            48,
            49,
            99,
            48,
            98,
            54,
            51,
            48,
            102,
            50,
            57,
            48,
            98,
            101,
            57
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            66,
            97,
            115,
            105,
            99,
            73,
            110,
            118,
            101,
            110,
            116,
            111,
            114,
            121,
            32,
            123,
            32,
            98,
            97,
            115,
            105,
            99,
            73,
            110,
            118,
            101,
            110,
            116,
            111,
            114,
            121,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            111,
            100,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            100,
            121,
            110,
            97,
            109,
            105,
            99,
            73,
            116,
            101,
            109,
            73,
            100,
            32,
            115,
            116,
            114,
            105,
            110,
            103,
            70,
            105,
            101,
            108,
            100,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query BasicInventory {
              basicInventory {
                nodes {
                  dynamicItemId
                  stringField
                }
              }
            }";
    }
}
