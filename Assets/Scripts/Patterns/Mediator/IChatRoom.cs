namespace Patterns.Mediator
{
    public interface IChatRoom
    {
        void Register(TeamMember teamMember);

        void Send(string from, string message);
    }
}