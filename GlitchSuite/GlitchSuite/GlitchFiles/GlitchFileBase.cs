using System;
using System.Collections.Generic;

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

    /// <summary>
    /// Offset of the data block of the <see cref="RawData"/>.
    /// This means, at this position the "real" data of the
    /// file begins.
    /// </summary>
    public int DataOffset { get; protected set; }

    public IDictionary<string, IHeader> Headers { get; protected set; }

    #endregion Properties

    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="rawData">The raw byte data of this file.</param>
    public GlitchFileBase(byte[] rawData)
    {
      RawData = rawData ?? throw new ArgumentNullException(nameof(rawData));
      Headers = new Dictionary<string, IHeader>();
    }

    #endregion Construction

    /// <summary>
    /// Reads different information from the header.
    /// </summary>
    protected abstract void ReadHeaderInfo();
  }
}