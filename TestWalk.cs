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
        walkerJane.Move();
      }
    }
  }
}

/************************************TEST OUTPUT***************************************

obsA: Subject Tom moved a step to the right
obsB: Subject Tom moved a step to the right
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the right
obsB: Subject Tom moved a step to the right
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the left
obsB: Subject Tom moved a step to the left
obsA: Subject Jane moved a step to the left
obsA: Subject Tom moved a step to the right
obsB: Subject Tom moved a step to the right
obsA: Subject Jane moved a step to the right
obsA: Subject Tom moved a step to the left
obsB: Subject Tom moved a step to the left
obsA: Subject Jane moved a step to the left

***********************************END TEST OUTPUT************************************/