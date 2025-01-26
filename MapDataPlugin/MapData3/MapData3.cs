using System;
using System.ComponentModel;
using System.Drawing.Design;
using PKHeX.Core;

namespace MapDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class MapData3
{
    public const int SIZE = Coords.SIZE + Warp3Data.SIZE + MiscMapData3.SIZE + MapView3.SIZE + ObjectEvent3Data.SIZE + ObjectEvent3TemplateData.SIZE;

    private SAV3 SaveFile { get; set; }

    private byte[] RawCoordsData;
    private byte[] RawWarpData;
    private byte[] RawMiscData;
    private byte[] RawMapViewData;
    private byte[] RawObjectEventData;
    private byte[] RawObjectEventTemplateData;

    public MapData3(SAV3 sav)
    {
        SaveFile = sav;

        RawCoordsData = SaveFile.Large[CurrentPositionOffset..WarpDataOffset];
        RawWarpData = SaveFile.Large[WarpDataOffset..MiscDataOffset];
        RawMiscData = SaveFile.Large[MiscDataOffset..MapViewOffset_RSE];
        RawMapViewData = SaveFile is IGen3Hoenn ?
            SaveFile.Large[MapViewOffset_RSE..(MapViewOffset_RSE + MapView3.SIZE)] :
            SaveFile.Small[MapViewOffset_FRLG..(MapViewOffset_FRLG + MapView3.SIZE)];
        RawObjectEventData = SaveFile.Large[ObjectEventsOffset..ObjectEventTemplatesOffset];
        RawObjectEventTemplateData = SaveFile.Large[ObjectEventTemplatesOffset..(ObjectEventTemplatesOffset + ObjectEvent3TemplateData.SIZE)];
    }

    public void SetData(byte[]data)
    {
        int eventsOffset = Coords.SIZE + Warp3Data.SIZE + MiscMapData3.SIZE + MapView3.SIZE;
        int eventsTemplatesOffset = eventsOffset + ObjectEvent3Data.SIZE;

        RawCoordsData = data[CurrentPositionOffset..WarpDataOffset];
        RawWarpData = data[WarpDataOffset..MiscDataOffset];
        RawMiscData = data[MiscDataOffset..MapViewOffset_RSE];
        RawMapViewData = data[MapViewOffset_RSE..eventsOffset];
        RawObjectEventData = data[eventsOffset..eventsTemplatesOffset];
        RawObjectEventTemplateData = data[eventsTemplatesOffset..(eventsTemplatesOffset + ObjectEvent3TemplateData.SIZE)];
    }

    public byte[] GetData() => [
        ..RawCoordsData,
        ..RawWarpData,
        ..RawMiscData,
        ..RawMapViewData,
        ..RawObjectEventData,
        ..RawObjectEventTemplateData
    ];

    private const int CurrentPositionOffset = 0;
    private const int WarpDataOffset = Coords.SIZE; // 4
    private const int MiscDataOffset = Coords.SIZE + Warp3Data.SIZE; // 8
    private const int MapViewOffset_RSE = MiscDataOffset + MiscMapData3.SIZE; // 0x10
    private const int MapViewOffset_FRLG = 0x898;
    private int ObjectEventsOffset => SaveFile is SAV3RS ? 0x9E0 : SaveFile is SAV3E ? 0xA30 : 0x6A0;
    private int ObjectEventTemplatesOffset => ObjectEventsOffset + ObjectEvent3Data.SIZE;

    [Editor(typeof(DataIOPropertyEditor), typeof(UITypeEditor))]
    public Coords CurrentPosition
    {
        get => new(RawCoordsData.AsMemory());
        set => RawCoordsData = value.Data.ToArray();
    }

    [Editor(typeof(DataIOPropertyEditor), typeof(UITypeEditor))]
    public Warp3Data WarpData
    {
        get => new(RawWarpData.AsMemory());
        set => RawWarpData = value.Data.ToArray();
    }

    [Editor(typeof(DataIOPropertyEditor), typeof(UITypeEditor))]
    public MiscMapData3 MapMiscData
    {
        get => new(RawMiscData.AsMemory());
        set => RawMiscData = value.Data.ToArray();
    }

    [Editor(typeof(MapViewPropertyEditor), typeof(UITypeEditor))]
    public MapView3 MapView
    {
        get => new(RawMapViewData);
        set => RawMapViewData = value.Data.ToArray();
    }

    [Editor(typeof(DataIOPropertyEditor), typeof(UITypeEditor))]
    public ObjectEvent3Data ObjectEvents
    {
        get => new(RawObjectEventData.AsMemory());
        set => RawObjectEventData = value.Data.ToArray();
    }

    [Editor(typeof(DataIOPropertyEditor), typeof(UITypeEditor))]
    public ObjectEvent3TemplateData ObjectEventTemplates
    {
        get => new(RawObjectEventTemplateData.AsMemory());
        set => RawObjectEventTemplateData = value.Data.ToArray();
    }

    public void Write()
    {
        RawCoordsData.CopyTo(SaveFile.Large.AsMemory()[CurrentPositionOffset..]);
        RawWarpData.CopyTo(SaveFile.Large.AsMemory()[WarpDataOffset..]);
        RawMiscData.CopyTo(SaveFile.Large.AsMemory()[MiscDataOffset..]);
        RawMapViewData.CopyTo(SaveFile is IGen3Hoenn ?
            SaveFile.Large.AsMemory()[MapViewOffset_RSE..] :
            SaveFile.Small.AsMemory()[MapViewOffset_FRLG..]);
        RawObjectEventData.CopyTo(SaveFile.Large.AsMemory()[ObjectEventsOffset..]);
        RawObjectEventTemplateData.CopyTo(SaveFile.Large.AsMemory()[ObjectEventTemplatesOffset..]);
    }
}
