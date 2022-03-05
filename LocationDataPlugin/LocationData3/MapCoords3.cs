namespace LocationDataPlugin
{
    internal class MapCoords3
    {
        public const int SIZE = 4;

        public byte[] Data { get; set; } = new byte[SIZE];

        public MapCoords3(byte[] data) => Data = data;
        public MapCoords3() => Data = new byte[SIZE];
        public MapCoords3(short x, short y)
        {
            X = x;
            Y = y;
        }

        public short X
        {
            get
            {
                return (short)((Data[0] & 0xFF) + (Data[1] << 8));
            }
            set
            {
                Data[0] = (byte)(value & 0xFF);
                Data[1] = (byte)(value >> 8);
            }
        }
        public short Y
        {
            get
            {
                return (short)((Data[2] & 0xFF) + (Data[3] << 8));
            }
            set
            {
                Data[2] = (byte)(value & 0xFF);
                Data[3] = (byte)(value >> 8);
            }
        }
    }
}
