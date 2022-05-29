namespace Facade
{
  internal class VideoFile: File
  {
    public string FileName { get; private set; }
    public VideoFile(string filename)
    {
      FileName = filename;
    }
  }
}