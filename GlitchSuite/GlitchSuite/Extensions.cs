using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlitchSuite
{
  /// <summary>
  /// Extensions for the <see cref="Array"/> type.
  /// </summary>
  public static class ArrayExtensions
  {
    /// <summary>
    /// Gets a sub-array of the given <paramref name="data"/>.
    /// </summary>
    /// <typeparam name="T">Type of the array.</typeparam>
    /// <param name="data">Array to get sub-array from.</param>
    /// <param name="index">Start index.</param>
    /// <param name="length">Amount of items.</param>
    /// <returns>Sub-array.</returns>
    public static T[] SubArray<T>(this T[] data, int index, int length)
    {
      T[] result = new T[length];
      Array.Copy(data, index, result, 0, length);
      return result;
    }

    /// <summary>
    /// Gets the combined value of the given amount
    /// of bytes of the <paramref name="bytes"/>.
    /// </summary>
    /// <param name="bytes">Byte array to get data from.</param>
    /// <param name="index">Start index.</param>
    /// <param name="length">Amount of bytes to combine.</param>
    /// <returns>Combined value.</returns>
    public static int GetValueOfBytes(this byte[] bytes, int index, int length)
    {
      int value = 0;
      for(int i = index; i < length; i++)
      {
        value += bytes[i];
      }

      return value;
    }
  }
}