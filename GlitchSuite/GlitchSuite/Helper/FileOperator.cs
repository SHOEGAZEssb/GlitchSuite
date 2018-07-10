﻿using System.IO;

namespace GlitchSuite.Helper
{
  /// <summary>
  /// Interfaces with files.
  /// </summary>
  public class FileOperator : IFileOperator
  {
    /// <summary>
    /// Deletes the specified file.
    /// </summary>
    /// <param name="path">The name of the file to be deleted.
    /// Wildcard characters are not supported.</param>
    public void Delete(string path)
    {
      File.Delete(path);
    }

    /// <summary>
    /// Creates a new file, writes the specified string to the file, and then closes
    /// the file. If the target file already exists, it is overwritten.
    /// </summary>
    /// <param name="path">The file to write to.</param>
    /// <param name="contents">The string to write to the file.</param>
    public void WriteAllLines(string path, string[] contents)
    {
      File.WriteAllLines(path, contents);
    }

    /// <summary>
    /// Creates a new file, writes the specified string to the file, and then closes
    /// the file. If the target file already exists, it is overwritten.
    /// </summary>
    /// <param name="path">The file to write to.</param>
    /// <param name="contents">The string to write to the file.</param>
    public void WriteAllText(string path, string contents)
    {
      File.WriteAllText(path, contents);
    }

    /// <summary>
    /// Opens a binary file, reads the contents of the file into a byte array, and then
    /// closes the file.
    /// </summary>
    /// <param name="path">The file to open for reading.</param>
    /// <returns>A byte array containing the contents of the file.</returns>
    public byte[] ReadAllBytes(string path)
    {
      return File.ReadAllBytes(path);
    }
  }
}