using UnityEngine;

namespace Patterns.Mediator
{
    public class Lawyer : TeamMember
    {
        public Lawyer(string name) 
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Debug.Log($"{nameof(Lawyer)} {Name} received:");
            base.Receive(from, message);
        }
    }
}