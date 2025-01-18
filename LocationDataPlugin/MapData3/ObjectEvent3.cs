using System;
using System.ComponentModel;

namespace LocationDataPlugin;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ObjectEvent3
{
    public const int SIZE = 0x24;

    [Browsable(false)]
    public Memory<byte> Data = new byte[SIZE];

    public ObjectEvent3(Memory<byte> data) => Data = data;
    public ObjectEvent3() { }

    public bool Active { get => (Data.Span[0] & 1) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~1) | (value ? 1 : 0)); }
    public bool SingleMovementActive { get => (Data.Span[0] & 2) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~2) | (value ? 2 : 0)); }
    public bool TriggerGroundEffectsOnMove { get => (Data.Span[0] & 4) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~4) | (value ? 4 : 0)); }
    public bool TriggerGroundEffectsOnStop { get => (Data.Span[0] & 8) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~8) | (value ? 8 : 0)); }
    public bool DisableCoveringGroundEffects { get => (Data.Span[0] & 0x10) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~0x10) | (value ? 0x10 : 0)); }
    public bool LandingJump { get => (Data.Span[0] & 0x20) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~0x20) | (value ? 0x20 : 0)); }
    public bool HeldMovementActive { get => (Data.Span[0] & 0x40) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~0x40) | (value ? 0x40 : 0)); }
    public bool HeldMovementFinished { get => (Data.Span[0] & 0x80) != 0; set => Data.Span[0] = (byte)((Data.Span[0] & ~0x80) | (value ? 0x80 : 0)); }

    public bool Frozen { get => (Data.Span[1] & 1) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~1) | (value ? 1 : 0)); }
    public bool FacingDirectionLocked { get => (Data.Span[1] & 2) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~2) | (value ? 2 : 0)); }
    public bool DisableAnim { get => (Data.Span[1] & 4) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~4) | (value ? 4 : 0)); }
    public bool EnableAnim { get => (Data.Span[1] & 8) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~8) | (value ? 8 : 0)); }
    public bool Inanimate { get => (Data.Span[1] & 0x10) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~0x10) | (value ? 0x10 : 0)); }
    public bool Invisible { get => (Data.Span[1] & 0x20) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~0x20) | (value ? 0x20 : 0)); }
    public bool OffScreen { get => (Data.Span[1] & 0x40) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~0x40) | (value ? 0x40 : 0)); }
    public bool TrackedByCamera { get => (Data.Span[1] & 0x80) != 0; set => Data.Span[1] = (byte)((Data.Span[1] & ~0x80) | (value ? 0x80 : 0)); }

    public bool IsPlayer { get => (Data.Span[2] & 1) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~1) | (value ? 1 : 0)); }
    public bool HasReflection { get => (Data.Span[2] & 2) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~2) | (value ? 2 : 0)); }
    public bool InShortGrass { get => (Data.Span[2] & 4) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~4) | (value ? 4 : 0)); }
    public bool InShallowFlowingWater { get => (Data.Span[2] & 8) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~8) | (value ? 8 : 0)); }
    public bool InSandPile { get => (Data.Span[2] & 0x10) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~0x10) | (value ? 0x10 : 0)); }
    public bool InHotSprings { get => (Data.Span[2] & 0x20) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~0x20) | (value ? 0x20 : 0)); }
    public bool HasShadow { get => (Data.Span[2] & 0x40) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~0x40) | (value ? 0x40 : 0)); }
    public bool SpriteAnimPausedBackup { get => (Data.Span[2] & 0x80) != 0; set => Data.Span[2] = (byte)((Data.Span[2] & ~0x80) | (value ? 0x80 : 0)); }

    public bool SpriteAffineAnimPausedBackup { get => (Data.Span[3] & 1) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~1) | (value ? 1 : 0)); }
    public bool DisableJumpLandingGroundEffect { get => (Data.Span[3] & 2) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~2) | (value ? 2 : 0)); }
    public bool FixedPriority { get => (Data.Span[3] & 4) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~4) | (value ? 4 : 0)); }
    public bool HideReflection { get => (Data.Span[3] & 8) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~8) | (value ? 8 : 0)); }
    // public bool Unused_0x3_4 { get => (Data.Span[3] & 0x10) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~0x10) | (value ? 0x10 : 0)); }
    // public bool Unused_0x3_5 { get => (Data.Span[3] & 0x20) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~0x20) | (value ? 0x20 : 0)); }
    // public bool Unused_0x3_6 { get => (Data.Span[3] & 0x40) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~0x40) | (value ? 0x40 : 0)); }
    // public bool Unused_0x3_7 { get => (Data.Span[3] & 0x80) != 0; set => Data.Span[3] = (byte)((Data.Span[3] & ~0x80) | (value ? 0x80 : 0)); }

    public byte SpriteId { get => Data.Span[4]; set => Data.Span[4] = value; }
    public byte GraphicsId { get => Data.Span[5]; set => Data.Span[5] = value; }
    public byte MovementType { get => Data.Span[6]; set => Data.Span[6] = value; }
    public byte TrainerType { get => Data.Span[7]; set => Data.Span[7] = value; }
    public byte LocalId { get => Data.Span[8]; set => Data.Span[8] = value; }
    public byte MapNum { get => Data.Span[9]; set => Data.Span[9] = value; }
    public byte MapGroup { get => Data.Span[0xA]; set => Data.Span[0xA] = value; }
    public byte CurrentElevation { get => (byte)(Data.Span[0xB] & 0x0F); set => Data.Span[0xB] = value; }
    public byte PreviousElevation { get => (byte)(Data.Span[0xB] & 0xF0); set => Data.Span[0xB] = value; }
    public Coords InitialCoordinates => new(Data[0xC..(0xC + Coords.SIZE)]);
    public Coords CurrentCoordinates => new(Data[0x10..(0x10 + Coords.SIZE)]);
    public Coords PreviousCoordinates => new(Data[0x14..(0x14 + Coords.SIZE)]);
    public byte FacingDirection { get => (byte)(Data.Span[0x18] & 0x0F); set => Data.Span[0x18] = value; }
    public byte MovementDirection { get => (byte)(Data.Span[0x18] & 0xF0); set => Data.Span[0x18] = value; }
    public byte RangeX { get => (byte)(Data.Span[0x19] & 0x0F); set => Data.Span[0x19] = value; }
    public byte RangeY { get => (byte)(Data.Span[0x19] & 0xF0); set => Data.Span[0x19] = value; }
    public byte FieldEffectSpriteId { get => Data.Span[0x1A]; set => Data.Span[0x1A] = value; }
    public byte WarpArrowSpriteId { get => Data.Span[0x1B]; set => Data.Span[0x1B] = value; }
    public byte MovementActionId { get => Data.Span[0x1C]; set => Data.Span[0x1C] = value; }
    public byte TrainerRangeBerryTreeId { get => Data.Span[0x1D]; set => Data.Span[0x1D] = value; }
    public byte CurrentMetatileBehavior { get => Data.Span[0x1E]; set => Data.Span[0x1E] = value; }
    public byte PreviousMetatileBehavior { get => Data.Span[0x1F]; set => Data.Span[0x1F] = value; }
    public byte PreviousMovementDirection { get => Data.Span[0x20]; set => Data.Span[0x20] = value; }
    public byte DirectionSequenceIndex { get => Data.Span[0x21]; set => Data.Span[0x21] = value; }
    public byte PlayerCopyableMovement { get => Data.Span[0x22]; set => Data.Span[0x22] = value; }

    public override string ToString()
    {
        return $"Active: {Active}, LocalId: {LocalId}, GraphisId: {GraphicsId}";
    }
}
