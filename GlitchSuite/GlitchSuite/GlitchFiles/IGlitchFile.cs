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
  }
}