using UnityEngine;

namespace Patterns.Memento
{
    public class MementoLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Memento Pattern Start: ");
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Debug.Log("Show History");
            caretaker.ShowHistory();

            Debug.Log("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Debug.Log("\n\nClient: Once more!\n");
            caretaker.Undo();
            Debug.Log("");
        }

    }
}


