using System;

namespace Facade
{
  internal class BitrateReader
  {
    public static VideoFile Read(VideoFile file, Codec codec)
    {
      return new VideoFile(file.FileName);
    }

    internal static VideoFile Convert(VideoFile buffer, Codec destinationCodec)
    {
      return new VideoFile(buffer.FileName);
    }
  }
}