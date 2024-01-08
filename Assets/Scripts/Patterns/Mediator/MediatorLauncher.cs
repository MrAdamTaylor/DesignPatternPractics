using UnityEngine;

namespace Patterns.Mediator
{
    public class MediatorLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Debug.Log("Pattern Mediator: ");
            TeamChatRoom teamChatRoom = new();

            var sven = new Lawyer("Sven");
            var kenneth = new Lawyer("Kenneth");
            var ann = new AccountManager("Ann");
            var john = new AccountManager("John");
            var kylie = new AccountManager("Kylie");
        
            teamChatRoom.Register(sven);
            teamChatRoom.Register(kenneth);
            teamChatRoom.Register(ann);
            teamChatRoom.Register(john);
            teamChatRoom.Register(kylie);
            
            ann.Send("Hi everyone, can someone have a look at file");
            sven.Send("On it!");
        }
    }
}