using JetBrains.Annotations;
using UnityEngine;

namespace Patterns.Mediator
{
    public abstract class TeamMember
    {
        [CanBeNull] private IChatRoom _chatRoom;

        public string Name { get; set; }

        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatroom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom?.Send(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Debug.Log($"Сообщение {from} до {Name}: {message}");
        }
    }
}