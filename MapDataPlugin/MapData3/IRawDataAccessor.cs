using System;

namespace MapDataPlugin;

public interface IRawDataAccessor
{
    public Memory<byte> Data { get; set; }
}
