// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_BIT_BLOB
        {
            internal int cbData;
            internal IntPtr pbData;
            internal int cUnusedBits;

            internal byte[] ToByteArray()
            {
                int numBytes = cbData;
                byte[] data = new byte[numBytes];
                Marshal.Copy(pbData, data, 0, numBytes);
                return data;
            }
        }
    }
}
