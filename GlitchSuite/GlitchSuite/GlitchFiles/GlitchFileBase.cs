using System;

namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// Base class for all <see cref="IGlitchFile"/>s.
  /// </summary>
  public abstract class GlitchFileBase : IGlitchFile
  {
    #region Properties

    /// <summary>
    /// The raw byte data of this file.
    /// </summary>
    public byte[] RawData { get; private set; }

    #endregion Properties

    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public GlitchFileBase(byte[] rawData)
    {
      RawData = rawData ?? throw new ArgumentNullException(nameof(rawData));
    }

    #endregion Construction
  }
}