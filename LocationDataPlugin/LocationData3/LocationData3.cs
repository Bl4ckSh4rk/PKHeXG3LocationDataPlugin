using System;

namespace LocationDataPlugin
{
    internal class LocationData3
    {
        public const int SIZE = MapCoords3.SIZE + (5 * WarpData3.SIZE) + 8; //0x34

        public byte[] Data { get; set; }

        public LocationData3(byte[] data) => Data = data;
        public LocationData3() => Data = new byte[SIZE];

        public MapCoords3 CurrentPosition
        {
            get => new(Data.AsSpan(0, MapCoords3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0);
        }

        public WarpData3 WarpLocation
        {
            get => new(Data.AsSpan(0x4, WarpData3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0x4);
        }
        public WarpData3 ContinueGameWarp
        {
            get => new(Data.AsSpan(0xC, WarpData3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0xC);
        }
        public WarpData3 DynamicWarp
        {
            get => new(Data.AsSpan(0x14, WarpData3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0x14);
        }
        public WarpData3 LastHealWarp
        {
            get => new(Data.AsSpan(0x1C, WarpData3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0x1C);
        }
        public WarpData3 EscapeWarp
        {
            get => new(Data.AsSpan(0x24, WarpData3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 0x24);
        }
        public ushort Music
        {
            get
            {
                return (ushort)((Data[0x2C] & 0xFF) + (Data[0x2D] << 8));
            }
            set
            {
                Data[0x2C] = (byte)(value & 0xFF);
                Data[0x2D] = (byte)(value >> 8);
            }
        }
        public byte Weather { get => Data[0x2E]; set => Data[0x2E] = value; }
        public byte WeatherCycleStage { get => Data[0x2F]; set => Data[0x2F] = value; } // 0 - 4, used on route 119 and 123
        public byte FlashLevel { get => Data[0x30]; set => Data[0x30] = value; } // 0 (bright) - 8 (black)
        public ushort MapLayoutId
        {
            get
            {
                return (ushort)((Data[0x32] & 0xFF) + (Data[0x33] << 8));
            }
            set
            {
                Data[0x32] = (byte)(value & 0xFF);
                Data[0x33] = (byte)(value >> 8);
            }
        }
    }
}
