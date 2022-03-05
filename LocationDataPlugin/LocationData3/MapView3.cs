namespace LocationDataPlugin
{
    internal class MapView3
    {
        public const int SIZE = 0x200;

        public byte[] Data { get; set; }

        public MapView3(byte[] data) => Data = data;
        public MapView3() => Data = new byte[SIZE];
    }
}
