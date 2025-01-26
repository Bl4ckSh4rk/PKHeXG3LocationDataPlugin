using System;
using System.ComponentModel;

namespace MapDataPlugin;

public sealed class MapView3 : IRawDataAccessor
{
    public const int SIZE = 0x200;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public MapView3(Memory<byte> data) => Data = data;
    public MapView3() { }
}
