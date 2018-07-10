namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A Bitmap file to glitch.
  /// </summary>
  public class BitmapGlitchFile : GlitchFileBase
  {
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
      // read bfOffBits (start of image data) (offset: 10)
      DataOffset = RawData[9];
    }

    #endregion Construction
  }
}