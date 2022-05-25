namespace Snapshot
{
  public partial class Point : ISnapshotCreator<Point>
  {
    public ISnapshot<Point> MakeSnapshot()
    {
      return new PointSnapshot(this);
    }

    public void RestoreState(ISnapshot<Point> pointSnapshot)
    {
      pointSnapshot.Restore(this);
    }

    private class PointSnapshot : ISnapshot<Point>
    {
      private readonly int _x;
      private readonly int _y;

      public PointSnapshot(Point p)
      {
        _x = p.X;
        _y = p.Y;
      }

      public void Restore(Point p)
      {
        p.X = _x;
        p.Y = _y;
      }
    }
  }
}
