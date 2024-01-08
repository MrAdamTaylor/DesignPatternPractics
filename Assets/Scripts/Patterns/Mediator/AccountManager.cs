using UnityEngine;

namespace Patterns.Mediator
{
    public class AccountManager : TeamMember
    {
        public AccountManager(string name) : base(name)
        {
        
        }

        public override void Receive(string from, string message)
        {
            Debug.Log($"{nameof(AccountManager)} {Name} received: ");
            base.Receive(from, message);
        }
    }
}