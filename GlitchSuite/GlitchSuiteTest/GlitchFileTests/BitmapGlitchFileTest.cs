using GlitchSuite.GlitchFiles;
using NUnit.Framework;

namespace GlitchSuiteTest.GlitchFileTests
{
  /// <summary>
  /// Tests for the <see cref="BitmapGlitchFile"/>.
  /// </summary>
  [TestFixture]
  class BitmapGlitchFileTest
  {
    /// <summary>
    /// Tests if the header of a Bitmap file
    /// is read correctly.
    /// </summary>
    [Test]
    public void ReadHeaderInfoTest()
    {
      // given: fake data
      byte[] data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 60, 10, 11, 12 };

      // when: creating the BitmapGlitchFile
      BitmapGlitchFile bm = new BitmapGlitchFile(data);

      // then: DataOffset is read
      Assert.That(bm.DataOffset, Is.EqualTo(60));
    }
  }
}