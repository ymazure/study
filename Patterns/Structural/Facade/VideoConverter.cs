using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
  public class VideoConverter
  {
    public File ConvertVideo(string fileName, string format)
    {
      Console.WriteLine("VideoConversionFacade: conversion started.");

      VideoFile file = new VideoFile(fileName);
      Codec sourceCodec = new CodecFactory().Extract(file);
      Codec destinationCodec;

      if (format == "mp4")
      {
        destinationCodec = new MPEG4CompressionCodec();
      }
      else
      {
        destinationCodec = new OggCompressionCodec();
      }

      VideoFile buffer = BitrateReader.Read(file, sourceCodec);
      VideoFile intermediateResult = BitrateReader.Convert(buffer, destinationCodec);
      File result = (new AudioMixer()).Fix(intermediateResult);

      Console.WriteLine("VideoConversionFacade: conversion completed.");
      return result;
    }
  }
}
