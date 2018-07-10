namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// A file to glitch.
  /// </summary>
  public interface IGlitchFile
  {
    /// <summary>
    /// The raw byte data of this file.
    /// </summary>
    byte[] RawData { get; }

    /// <summary>
    /// Offset of the data block of the <see cref="RawData"/>.
    /// This means, at this position the "real" data of the
    /// file begins.
    /// </summary>
    int DataOffset { get; }
  }
}