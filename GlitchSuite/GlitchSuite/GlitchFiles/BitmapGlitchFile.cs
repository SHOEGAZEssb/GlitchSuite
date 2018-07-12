using GlitchSuite.Bitmap;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A Bitmap file to glitch.
  /// </summary>
  public class BitmapGlitchFile : GlitchFileBase
  {
    #region Constants

    public const string FILEHEADERNAME = "File Header";

    #endregion Constants

    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public BitmapGlitchFile(byte[] rawData)
      : base(rawData)
    {
      ReadHeaderInfo();
    }

    /// <summary>
    /// Reads different information from the header.
    /// </summary>
    protected override void ReadHeaderInfo()
    {
      Headers.Add(FILEHEADERNAME, EndianHelper.BytesToStruct<FileHeader>(RawData.SubArray(0, 14)));
    }

    #endregion Construction
  }
}