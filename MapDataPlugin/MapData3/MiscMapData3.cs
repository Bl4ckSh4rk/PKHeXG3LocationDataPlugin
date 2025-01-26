using System;
using System.ComponentModel;
using static System.Buffers.Binary.BinaryPrimitives;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class MiscMapData3 : IRawDataAccessor
{
    public const int SIZE = 8;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public MiscMapData3(Memory<byte> data) => Data = data;
    public MiscMapData3() { }

    public ushort Music
    {
        get => ReadUInt16LittleEndian(Data.Span[0..]);
        set => WriteUInt16LittleEndian(Data.Span[0..], value);
    }
    public byte Weather { get => Data.Span[2]; set => Data.Span[2] = value; }
    public byte WeatherCycleStage { get => Data.Span[3]; set => Data.Span[3] = value; } // 0 - 4, used on route 119 and 123
    public byte FlashLevel { get => Data.Span[4]; set => Data.Span[4] = value; } // 0 (bright) - 8 (black)

    // public byte Unused_0x31 { get => Data.Span[5]; set => Data.Span[5] = value; }

    public ushort MapLayoutId
    {
        get => ReadUInt16LittleEndian(Data.Span[6..]);
        set => WriteUInt16LittleEndian(Data.Span[6..], value);
    }

    public override string ToString()
    {
        return $"Music: {Music}, Weather: {Weather}, FlashLevel: {FlashLevel}";
    }
}
