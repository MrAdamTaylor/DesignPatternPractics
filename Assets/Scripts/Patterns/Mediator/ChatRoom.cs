namespace Patterns.Mediator
{
    public abstract class ChatRoom
    {
        public abstract void Register(TeamMember teamMember);

        public abstract void Send(string from, string message);
    }
}