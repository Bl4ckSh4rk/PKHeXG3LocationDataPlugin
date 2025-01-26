using System;

namespace MapDataPlugin;

internal interface IRawDataAccessor
{
    public Memory<byte> Data { get; set; }
}
