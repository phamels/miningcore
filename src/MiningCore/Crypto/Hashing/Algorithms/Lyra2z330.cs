using System;
using MiningCore.Contracts;
using MiningCore.Native;

namespace MiningCore.Crypto.Hashing.Algorithms
{
    public unsafe class Lyra2z330 : IHashAlgorithm
    {
        public byte[] Digest(byte[] data, params object[] extra)
        {
            Contract.RequiresNonNull(data, nameof(data));

            var result = new byte[32];

            fixed (byte* input = data)
            {
                fixed (byte* output = result)
                {
                    LibMultihash.lyra2z330(input, output, (uint)data.Length);
                }
            }

            return result;
        }
    }
}
