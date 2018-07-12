using System.Runtime.InteropServices;

namespace GlitchSuite.Bitmap
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public class FileHeader : IHeader
  {
    [Endian(Endianness.BigEndian)]
    public short bfType;

    [Endian(Endianness.LittleEndian)]
    public int bfSize;

    [Endian(Endianness.LittleEndian)]
    public int bfReserved;

    [Endian(Endianness.LittleEndian)]
    public int bfOffBits;
  }
}