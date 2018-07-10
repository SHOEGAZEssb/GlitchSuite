using GlitchSuite.GlitchFiles;
using GlitchSuite.Helper;
using Moq;
using NUnit.Framework;

namespace GlitchSuiteTest.UnitTests.GlitchFileTests
{
  /// <summary>
  /// Tests for the <see cref="GlitchFileFactory"/>.
  /// </summary>
  [TestFixture]
  class GlitchFileFactoryTest
  {
    /// <summary>
    /// Tests the opening of a bitmap.
    /// </summary>
    [Test]
    public void OpenBitmapTest()
    {
      // given: IFileOperator Mock
      string path = "C:\\TestImage.bmp";
      byte[] bytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

      Mock<IFileOperator> fileOperatorMock = new Mock<IFileOperator>(MockBehavior.Strict);
      fileOperatorMock.Setup(f => f.ReadAllBytes(path)).Returns(bytes);

      GlitchFileFactory factory = new GlitchFileFactory(fileOperatorMock.Object);

      // when: opening the path
      var file = factory.OpenFile(path);

      // then: correct type
      Assert.That(file, Is.InstanceOf<BitmapGlitchFile>());
      Assert.That(file.RawData, Is.EqualTo(bytes));
    }
  }
}