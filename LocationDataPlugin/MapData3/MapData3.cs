using System;
using System.ComponentModel;
using System.Drawing.Design;
using PKHeX.Core;

namespace LocationDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class MapData3
{
    private SAV3 SaveFile { get; set; }

    private readonly byte[] RawCoordsData;
    private readonly byte[] RawWarpData;
    private readonly byte[] RawMiscData;
    private byte[] RawMapViewData;
    private readonly byte[] RawObjectEventData;
    private readonly byte[] RawObjectEventTemplateData;

    public MapData3(SAV3 sav)
    {
        SaveFile = sav;

        RawCoordsData = SaveFile.Large[CurrentPositionOffset..Coords.SIZE];
        RawWarpData = SaveFile.Large[WarpDataOffset..(WarpDataOffset + Warp3Data.SIZE)];
        RawMiscData = SaveFile.Large[MiscDataOffset..(MiscDataOffset + Warp3Data.SIZE)];
        RawMapViewData = SaveFile is SAV3RS or SAV3E ?
            SaveFile.Large[MapViewOffset_RSE..(MapViewOffset_RSE + MapView3.SIZE)] :
            SaveFile.Small[MapView3.OFFSET_FRLG..(MapView3.OFFSET_FRLG + MapView3.SIZE)];
        RawObjectEventData = SaveFile.Large[ObjectEventsOffset..(ObjectEventsOffset + ObjectEvent3Data.SIZE)];
        RawObjectEventTemplateData = SaveFile.Large[ObjectEventTemplatesOffset..(ObjectEventTemplatesOffset + ObjectEvent3TemplateData.SIZE)];
    }

    private const int CurrentPositionOffset = 0;
    private const int WarpDataOffset = Coords.SIZE; // 4
    private const int MiscDataOffset = Coords.SIZE + Warp3.SIZE; // 8
    private const int MapViewOffset_RSE = MiscDataOffset + MiscMapData3.SIZE; // 0x10
    private int ObjectEventsOffset => SaveFile is SAV3RS ? ObjectEvent3Data.OFFSET_RS : SaveFile is SAV3E ? ObjectEvent3Data.OFFSET_E : ObjectEvent3Data.OFFSET_FRLG;
    private int ObjectEventTemplatesOffset => SaveFile is SAV3RS ? ObjectEvent3TemplateData.OFFSET_RS : SaveFile is SAV3E ? ObjectEvent3TemplateData.OFFSET_E : ObjectEvent3TemplateData.OFFSET_FRLG;

    public Coords CurrentPosition => new(RawCoordsData.AsMemory());

    public Warp3Data WarpData => new(RawWarpData.AsMemory());

    public MiscMapData3 MapMiscData => new(RawMiscData.AsMemory());

    [Editor(typeof(MapViewPropertyEditor), typeof(UITypeEditor))]
    public MapView3 MapView
    {
        get => new(RawMapViewData);
        set => RawMapViewData = value.Data.ToArray();
    }

    public ObjectEvent3Data ObjectEvents => new(RawObjectEventData.AsMemory());
    public ObjectEvent3TemplateData ObjectEventTemplates => new(RawObjectEventTemplateData.AsMemory());

    public void Write()
    {
        RawCoordsData.CopyTo(SaveFile.Large.AsMemory()[CurrentPositionOffset..]);
        RawWarpData.CopyTo(SaveFile.Large.AsMemory()[WarpDataOffset..]);
        RawMiscData.CopyTo(SaveFile.Large.AsMemory()[MiscDataOffset..]);
        RawMapViewData.CopyTo(SaveFile is SAV3RS or SAV3E ?
            SaveFile.Large.AsMemory()[MapViewOffset_RSE..] :
            SaveFile.Small.AsMemory()[MapView3.OFFSET_FRLG..]);
        RawObjectEventData.CopyTo(SaveFile.Large.AsMemory()[ObjectEventsOffset..]);
        RawObjectEventTemplateData.CopyTo(SaveFile.Large.AsMemory()[ObjectEventTemplatesOffset..]);
    }
}
