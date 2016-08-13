using System.Collections.ObjectModel;
using ImageResizer.Properties;
using Xunit;

namespace ImageResizer.Models
{
    public class ResizeOperationTests
    {
        [Theory]
        [InlineData("Test.jpg")]
        [InlineData("Test.png")]
        [InlineData("Test1.gif")]
        [InlineData("Test2.gif")]
        [InlineData("Test.tif")]
        public void Execute_works(string file)
        {
            using (var dir = new TestDirectory())
            {
                var operation = new ResizeOperation(
                    file,
                    dir.Path,
                    new Settings
                    {
                        Sizes = new ObservableCollection<ResizeSize>
                        {
                            new ResizeSize
                            {
                                Name = "Small",
                                Fit = ResizeFit.Fit,
                                Width = 854,
                                Height = 480,
                                Unit = ResizeUnit.Pixel
                            }
                        },
                        IgnoreOrientation = true,
                        FileName = "%1 (%2)"
                    });

                operation.Execute();

                // TODO: Assert
            }
        }
    }
}
