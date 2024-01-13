using UnityEngine;

namespace Patterns
{
    public class PatternsLauncher : MonoBehaviour
    {
        [SerializeField]
        private DesignPatternLauncher[] _patterns;
    

        public void Awake()
        {
            for (int i = 0; i < _patterns.Length; i++)
            {
                _patterns[i].Launch();
            }
        }
    }
}