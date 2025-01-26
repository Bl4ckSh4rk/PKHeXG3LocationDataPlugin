using System;
using System.ComponentModel;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ObjectEvent3TemplateData : IRawDataAccessor
{
    public const int SIZE = ObjectEvent3Template.SIZE * COUNT; // 0x600
    public const int COUNT = 64;

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
