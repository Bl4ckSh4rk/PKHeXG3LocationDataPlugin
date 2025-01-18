using System;
using System.ComponentModel;

namespace LocationDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Warp3
{
    public const int SIZE = Coords.SIZE + 4; // 8

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public Warp3(Memory<byte> data) => Data = data;
    public Warp3() { }

    public byte Group { get => Data.Span[0]; set => Data.Span[0] = value; }
    public byte Number { get => Data.Span[1]; set => Data.Span[1] = value; }
    public byte Id { get => Data.Span[2]; set => Data.Span[2] = value; }

    // public byte Unused_0x3 { get => Data.Span[3]; set => Data.Span[3] = value; }

    public Coords Coords => new(Data[4..(4 + Coords.SIZE)]);

    public override string ToString()
    {
        return $"Group: {Group}, Number: {Number}, ID: {Id}, X: {Coords.X}, Y: {Coords.Y}";
    }
}
