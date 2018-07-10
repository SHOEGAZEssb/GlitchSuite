namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A binary / unknown file to glitch.
  /// </summary>
  class BinaryGlitchFile : GlitchFileBase
  {
    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public BinaryGlitchFile(byte[] rawData)
      : base(rawData)
    {
      ReadHeaderInfo();
    }

    #endregion Construction

    /// <summary>
    /// Reads different information from the header.
    /// </summary>
    protected override void ReadHeaderInfo()
    {
      DataOffset = 0;
    }
  }
}