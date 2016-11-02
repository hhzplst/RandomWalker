using System;
using System.Collections.Generic;

namespace RandomWalker {
    public class RandomWalker {
        Random r = new Random();
        private List<IRandomWalkObserver> observers = new List<IRandomWalkObserver>();
        public string Name {get; set;}
        public RandomWalker(string name) {
            Name = name;
        }
        public void AddObserver(IRandomWalkObserver obs) {
            observers.Add(obs);
        }
        public void RemoveObserver(IRandomWalkObserver obs) {
            observers.Remove(obs);
        }
        public void Move() {
            foreach(IRandomWalkObserver obs in observers)
                obs.Moved(this, GetDirection());
        }
        public string GetDirection() {
            double d = r.NextDouble();
            if (d < 0.5) return "left";
            else return "right";
        }
    }
}