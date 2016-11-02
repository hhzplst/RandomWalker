using System;

namespace RandomWalker {
  public class RandomWalkerObserverImpl : IRandomWalkObserver{
    public void Moved(RandomWalker subject, string direction) {
      Console.WriteLine("Subject {0} moved a step to the {1}", subject.Name, direction);
    }
  }
}