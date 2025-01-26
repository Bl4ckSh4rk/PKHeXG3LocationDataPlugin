using System;
using System.ComponentModel;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ObjectEvent3TemplateData : IRawDataAccessor
{
    public const int SIZE = ObjectEvent3Template.SIZE * COUNT; // 0x600
    public const int COUNT = 64;

    public const int OFFSET_RS = ObjectEvent3Data.OFFSET_RS + ObjectEvent3Data.SIZE;     // 0xC20
    public const int OFFSET_E = ObjectEvent3Data.OFFSET_E + ObjectEvent3Data.SIZE;       // 0xC70
    public const int OFFSET_FRLG = ObjectEvent3Data.OFFSET_FRLG + ObjectEvent3Data.SIZE; // 0x8E0

    [Browsable(false)]
    public Memory<byte> Data { get; set; } = new byte[SIZE];

    public ObjectEvent3TemplateData(Memory<byte> data) => Data = data;
    public ObjectEvent3TemplateData() { }

    public ObjectEvent3Template GetObjectEvent(int index) => new(Data[(ObjectEvent3Template.SIZE * index)..((ObjectEvent3Template.SIZE * index) + ObjectEvent3Template.SIZE)]);

    public ObjectEvent3Template[] ObjectEvents
    {
        get
        {
            ObjectEvent3Template[] obj = new ObjectEvent3Template[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                obj[i] = GetObjectEvent(i);
            }
            return obj;
        }
    }
}
