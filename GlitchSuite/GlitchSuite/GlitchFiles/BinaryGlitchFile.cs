namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A binary / unknown file to glitch.
  /// </summary>
  class BinaryGlitchFile : GlitchFileBase
  {
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public BinaryGlitchFile(byte[] rawData)
      : base(rawData)
    { }
  }
}