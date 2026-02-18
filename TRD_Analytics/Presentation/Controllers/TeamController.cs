using TRD_Analytics.Application;
using TRD_Analytics.Application.DTO;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Presentation;

public static class TeamController
{
    public static List<TeamDto> GetAllTeams()
    {
        GetAllTeamsSortedAlphUserCase useCase = new(new TeamRepository());
        return useCase.Execute();
    }
}