using System;
using System.ComponentModel;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ObjectEvent3Data : IRawDataAccessor
{
    public const int SIZE = ObjectEvent3.SIZE * COUNT; // 0x240;
    public const int COUNT = 16;

    public const int OFFSET_RS = 0x9E0;
    public const int OFFSET_E = 0xA30;
    public const int OFFSET_FRLG = 0x6A0;

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public ObjectEvent3Data(Memory<byte> data) => Data = data;
    public ObjectEvent3Data() { }

    public ObjectEvent3 GetObjectEvent(int index) => new(Data[(ObjectEvent3.SIZE * index)..((ObjectEvent3.SIZE * index) + ObjectEvent3.SIZE)]);

    public ObjectEvent3[] ObjectEvents
    {
        get
        {
            ObjectEvent3[] obj = new ObjectEvent3[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                obj[i] = GetObjectEvent(i);
            }
            return obj;
        }
    }
}
