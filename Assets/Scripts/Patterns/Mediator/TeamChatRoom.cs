using System.Collections.Generic;

namespace Patterns.Mediator
{
    public class TeamChatRoom : IChatRoom
    {
        private readonly Dictionary<string, TeamMember> _teamMembers = new();

        public void Register(TeamMember teamMember)
        {
            teamMember.SetChatroom(this);
            if (!_teamMembers.ContainsKey(teamMember.Name))
            {
                _teamMembers.Add(teamMember.Name, teamMember);
            }
        }

        public void Send(string from, string message)
        {
            foreach (var teamMember in _teamMembers.Values)
            {
                teamMember.Receive(from, message);
            }
        }
    }
}