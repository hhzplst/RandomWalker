namespace RandomWalker {
  public interface IRandomWalkObserver {
    void Moved(RandomWalker subject, string direction);
  }
}