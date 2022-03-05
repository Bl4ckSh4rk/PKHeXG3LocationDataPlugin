using System;

namespace LocationDataPlugin
{
    internal class WarpData3
    {
        public const int SIZE = MapCoords3.SIZE + 4; // 8

        public byte[] Data { get; set; }

        public WarpData3(byte[] data) => Data = data;
        public WarpData3() => Data = new byte[SIZE];

        public byte Group { get => Data[0]; set => Data[0] = value; }
        public byte Number { get => Data[1]; set => Data[1] = value; }
        public byte Id { get => Data[2]; set => Data[2] = value; }
        public byte Unused { get => Data[3]; set => Data[3] = value; }
        public MapCoords3 Coords
        {
            get => new(Data.AsSpan(4, MapCoords3.SIZE).ToArray());
            set => value.Data.CopyTo(Data, 4);
        }
    }
}
