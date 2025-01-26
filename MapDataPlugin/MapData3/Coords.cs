using System;
using System.ComponentModel;
using static System.Buffers.Binary.BinaryPrimitives;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Coords : IRawDataAccessor
{
    public const int SIZE = 4;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public Coords(Memory<byte> data) => Data = data;
    public Coords() { }
    public Coords(short x, short y)
    {
        X = x;
        Y = y;
    }

    public short X
    {
        get => ReadInt16LittleEndian(Data.Span[0..]);
        set => WriteInt16LittleEndian(Data.Span[0..], value);
    }
    public short Y
    {
        get => ReadInt16LittleEndian(Data.Span[2..]);
        set => WriteInt16LittleEndian(Data.Span[2..], value);
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }
}
