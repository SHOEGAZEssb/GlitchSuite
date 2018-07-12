using GlitchSuite.Bitmap;
using GlitchSuite.GlitchFiles;
using NUnit.Framework;
using System.Linq;

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
    private const string TESTPATTERNPATH = TESTDATAPATH + "TestPattern_2x2_24bit.bmp";

    /// <summary>
    /// Tests if the header of a Bitmap file
    /// is read correctly.
    /// </summary>
    [Test]
    public void ReadFileHeaderInfoTest()
    {
      // given: GlitchFileFactory
      GlitchFileFactory factory = new GlitchFileFactory();

      // when: creating a BitmapGlitchFile
      var bm = factory.OpenFile(TESTPATTERNPATH);

      // then: File Header correct
      var header = (FileHeader)bm.Headers.FirstOrDefault().Value;

      Assert.That(header.bfType, Is.EqualTo(16973));
      Assert.That(header.bfSize, Is.EqualTo(70));
      Assert.That(header.bfReserved, Is.EqualTo(0));
      Assert.That(header.bfOffBits, Is.EqualTo(54));
    }
  }
}