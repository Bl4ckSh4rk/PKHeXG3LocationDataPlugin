using System;
using System.ComponentModel;

namespace LocationDataPlugin;

public sealed class MapView3
{
    public const int SIZE = 0x200;

    public const int OFFSET_RSE = 0x034; // Large chunk
    public const int OFFSET_FRLG = 0x898; // Small chunk

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public MapView3(Memory<byte> data) => Data = data;
    public MapView3() { }
}
