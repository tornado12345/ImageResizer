using System;
using System.IO;

namespace ImageResizer
{
    public class TestDirectory : IDisposable
    {
        public TestDirectory()
        {
            Path = System.IO.Path.GetRandomFileName();
            Directory.CreateDirectory(Path);
        }

        public string Path { get; }

        public void Dispose()
            => Directory.Delete(Path, recursive: true);
    }
}
