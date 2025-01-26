using System;
using System.ComponentModel;
using static System.Buffers.Binary.BinaryPrimitives;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ObjectEvent3Template : IRawDataAccessor
{
    public const int SIZE = 0x18;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];
    public ObjectEvent3Template(Memory<byte> data) => Data = data;
    public ObjectEvent3Template() { }

    public byte LocalId { get => Data.Span[0]; set => Data.Span[0] = value; }
    public byte GraphicsId { get => Data.Span[1]; set => Data.Span[1] = value; }
    public byte Kind { get => Data.Span[2]; set => Data.Span[2] = value; }
    public Coords Coordinates => new(Data[4..(4 + Coords.SIZE)]);
    public byte Elevation { get => Data.Span[8]; set => Data.Span[8] = value; }
    public byte MovementType { get => Data.Span[9]; set => Data.Span[9] = value; }
    public byte MovementRangeX { get => (byte)(Data.Span[0xA] & 0x0F); set => Data.Span[0xA] = value; }
    public byte MovementRangeY { get => (byte)(Data.Span[0xA] & 0xF0); set => Data.Span[0xA] = value; }
    public ushort TrainerType
    {
        get => ReadUInt16LittleEndian(Data.Span[0xC..]);
        set => WriteUInt16LittleEndian(Data.Span[0xC..], value);
    }
    public ushort TrainerRangeBerryTreeId
    {
        get => ReadUInt16LittleEndian(Data.Span[0xE..]);
        set => WriteUInt16LittleEndian(Data.Span[0xE..], value);
    }
    public uint ScriptPointer
    {
        get => ReadUInt32LittleEndian(Data.Span[0x10..]);
        set => WriteUInt32LittleEndian(Data.Span[0x10..], value);
    }
    public ushort FlagId
    {
        get => ReadUInt16LittleEndian(Data.Span[0x14..]);
        set => WriteUInt16LittleEndian(Data.Span[0x14..], value);
    }

    public override string ToString()
    {
        return $"LocalId: {LocalId}, GraphisId: {GraphicsId}";
    }
}
