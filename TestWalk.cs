namespace RandomWalker {
  public class TestWalk {
    public static void Main(string[] args) {
      RandomWalker walkerTom = new RandomWalker("Tom");
      RandomWalker walkerJane = new RandomWalker("Jane");

      RandomWalkerObserverImpl obsA = new RandomWalkerObserverImpl("obsA");
      RandomWalkerObserverImpl obsB = new RandomWalkerObserverImpl("obsB");

      walkerTom.AddObserver(obsA);
      walkerTom.AddObserver(obsB);

      walkerJane.AddObserver(obsA);

      for(int i = 0; i < 5; i++) {
        walkerTom.Move();
      }
    }
  }
}