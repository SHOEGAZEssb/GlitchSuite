using GlitchSuite.GlitchFiles;
using NUnit.Framework;

namespace GlitchSuiteTest.IntegrationTests.GlitchFileTests
{
  /// <summary>
  /// Integration tests for the
  /// <see cref="BitmapGlitchFile"/>.
  /// </summary>
  [TestFixture]
  class BitmapGlitchFileTest
  {
    /// <summary>
    /// Path of the test bitmaps.
    /// </summary>
    private const string TESTDATAPATH = @"../../IntegrationTests/TestData/Images/Bitmaps/";

    /// <summary>
    /// Path of the test pattern bitmap.
    /// </summary>
    private const string TESTPATTERNPATH = TESTDATAPATH + "TestPattern_1280x800.bmp";

    /// <summary>
    /// Tests if the header of a Bitmap file
    /// is read correctly.
    /// </summary>
    [Test]
    public void ReadHeaderInfoTest()
    {
      // given: GlitchFileFactory
      GlitchFileFactory factory = new GlitchFileFactory();

      // when: creating a BitmapGlitchFile
      var bm = factory.OpenFile(TESTPATTERNPATH);

      // then: DataOffset correct
      Assert.That(bm.DataOffset, Is.EqualTo(54));
    }
  }
}