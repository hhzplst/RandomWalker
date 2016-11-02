using System;

namespace RandomWalker {
  public class RandomWalkerObserverImpl : IRandomWalkObserver{
    
    public string ObsName {get; set;}
    public RandomWalkerObserverImpl(string name) {
      ObsName = name;
    }
    public void Moved(RandomWalker subject, string direction) {
      Console.WriteLine("{0}: Subject {0} moved a step to the {1}", ObsName, subject.SubjectName, direction);
    }
  }
}