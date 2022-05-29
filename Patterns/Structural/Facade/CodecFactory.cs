namespace Facade
{
  internal class CodecFactory
  {
    public Codec Extract(File file)
    {
      return new Codec();
    }
  }
}