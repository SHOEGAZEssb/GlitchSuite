namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A Bitmap file to glitch.
  /// </summary>
  public class BitmapGlitchFile : GlitchFileBase
  {
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public BitmapGlitchFile(byte[] rawData)
      : base(rawData)
    { }
  }
}