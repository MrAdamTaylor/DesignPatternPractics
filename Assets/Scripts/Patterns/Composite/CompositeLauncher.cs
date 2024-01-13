using UnityEngine;

namespace Patterns.Composite
{
    public class CompositeLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Запущен паттерн Композиция: ");
            var root = new Directory("root", 0);
            var topLevelFile = new File("toplevel.txt", 100);
            var topLevelDirectory1 = new Directory("topleveldirectory1", 4);
            var topLevelDirectory2 = new Directory("topLevelDirectory2", 4);

            root.Add(topLevelFile);
            root.Add(topLevelDirectory1);
            root.Add(topLevelDirectory2);
        
            var subLevelFile1 = new File("sublevel1.txt", 200);
            var subLevelFile2 = new File("sublevel2.txt", 150);
        
            topLevelDirectory1.Add(subLevelFile1);
            topLevelDirectory2.Add(subLevelFile2);
        
            Debug.Log($"Size of topLevelDirectory1: {topLevelDirectory1.GetSize()}");
            Debug.Log($"Size of topLevelDirectory2: {topLevelDirectory2.GetSize()}");
            Debug.Log($"Size of root: {root.GetSize()}");
            Debug.Log("");
        }
    }
}