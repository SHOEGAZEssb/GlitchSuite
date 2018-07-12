using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GlitchSuite
{
  [AttributeUsage(AttributeTargets.Field)]
  public class EndianAttribute : Attribute
  {
    public Endianness Endianness { get; private set; }

    public EndianAttribute(Endianness endianness)
    {
      Endianness = endianness;
    }
  }

  public enum Endianness
  {
    BigEndian,
    LittleEndian
  }

  public static class EndianHelper
  {
    private static void RespectEndianness(Type type, byte[] data)
    {
      var fields = type.GetFields().Where(f => f.IsDefined(typeof(EndianAttribute), false))
          .Select(f => new
          {
            Field = f,
            Attribute = (EndianAttribute)f.GetCustomAttributes(typeof(EndianAttribute), false)[0],
            Offset = Marshal.OffsetOf(type, f.Name).ToInt32()
          }).ToList();

      foreach (var field in fields)
      {
        if ((field.Attribute.Endianness == Endianness.BigEndian && BitConverter.IsLittleEndian) ||
            (field.Attribute.Endianness == Endianness.LittleEndian && !BitConverter.IsLittleEndian))
        {
          Array.Reverse(data, field.Offset, Marshal.SizeOf(field.Field.FieldType));
        }
      }
    }

    public static T BytesToStruct<T>(byte[] rawData)
    {
      T result = default(T);

      RespectEndianness(typeof(T), rawData);

      GCHandle handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);

      try
      {
        IntPtr rawDataPtr = handle.AddrOfPinnedObject();
        result = (T)Marshal.PtrToStructure(rawDataPtr, typeof(T));
      }
      finally
      {
        handle.Free();
      }

      return result;
    }
  }
}
