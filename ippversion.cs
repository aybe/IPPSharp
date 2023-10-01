using System;

namespace Intel
{
    public static partial class ipps
    {
        [NativeTypeName("#define IPP_VERSION_MAJOR 2021")]
        public const int IPP_VERSION_MAJOR = 2021;

        [NativeTypeName("#define IPP_VERSION_MINOR 9")]
        public const int IPP_VERSION_MINOR = 9;

        [NativeTypeName("#define IPP_VERSION_UPDATE 0")]
        public const int IPP_VERSION_UPDATE = 0;

        [NativeTypeName("#define IPP_VERSION_STR \"2021.9.0\"")]
        public static ReadOnlySpan<byte> IPP_VERSION_STR => new byte[] { 0x32, 0x30, 0x32, 0x31, 0x2E, 0x39, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define IPP_INTERFACE_VERSION_MAJOR 10")]
        public const int IPP_INTERFACE_VERSION_MAJOR = 10;

        [NativeTypeName("#define IPP_INTERFACE_VERSION_MINOR 8")]
        public const int IPP_INTERFACE_VERSION_MINOR = 8;
    }
}
