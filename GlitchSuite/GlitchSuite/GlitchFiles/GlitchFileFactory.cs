using GlitchSuite.Helper;
using System;
using System.IO;

namespace GlitchSuite.GlitchFiles
{
  /// <summary>
  /// Factory for opening glitch files.
  /// </summary>
  public class GlitchFileFactory
  {
    #region Member

    /// <summary>
    /// FileOperator used to read and write files.
    /// </summary>
    private IFileOperator _fileOperator;

    #endregion Member

    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="fileOperator">FileOperator used to read and write files.</param>
    public GlitchFileFactory(IFileOperator fileOperator)
    {
      _fileOperator = fileOperator ?? throw new ArgumentNullException(nameof(fileOperator));
    }

    #endregion Construction

    /// <summary>
    /// Creates the correct <see cref="IGlitchFile"/>
    /// for the corresponding extension of <paramref name="path"/>.
    /// </summary>
    /// <param name="path">File to open.</param>
    /// <returns>Glitch file.</returns>
    public IGlitchFile OpenFile(string path)
    {
      if (string.IsNullOrEmpty(path))
        throw new ArgumentException(string.Format("{0} can't be null or empty", nameof(path)), nameof(path));

      switch(Path.GetExtension(path).ToLower())
      {
        case ".bmp":
          return new BitmapGlitchFile(_fileOperator.ReadAllBytes(path));
        default:
          return new BinaryGlitchFile(_fileOperator.ReadAllBytes(path));
      }
    }
  }
}