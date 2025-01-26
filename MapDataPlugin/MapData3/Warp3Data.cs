using System;
using System.ComponentModel;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class Warp3Data : IRawDataAccessor
{
    public const int SIZE = Warp3.SIZE * COUNT; // 0x28
    public const int COUNT = 5;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public Warp3Data(Memory<byte> data) => Data = data;
    public Warp3Data() { }

    [Browsable(false)]
    public Warp3[] Warps =>
    [
        WarpLocation,
        ContinueGameWarp,
        DynamicWarp,
        LastHealWarp,
        EscapeWarp
    ];

    public Warp3 WarpLocation => new(Data[0..Warp3.SIZE]);
    public Warp3 ContinueGameWarp => new(Data[0x8..(0x8 + Warp3.SIZE)]);
    public Warp3 DynamicWarp => new(Data[0x10..(0x10 + Warp3.SIZE)]);
    public Warp3 LastHealWarp => new(Data[0x18..(0x18 + Warp3.SIZE)]);
    public Warp3 EscapeWarp => new(Data[0x20..(0x20 + Warp3.SIZE)]);
}
