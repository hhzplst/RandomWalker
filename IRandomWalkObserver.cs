using System;

namespace RandomWalker {
  public interface IRandomWalkObserver {
    void Moved(Object RandomWalkEvent, string direction);
  }
}