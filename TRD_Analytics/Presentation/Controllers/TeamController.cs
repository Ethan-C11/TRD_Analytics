using TRD_Analytics.Application;

namespace TRD_Analytics.Presentation;

public static class TeamController
{
    public static void GetAllTeams()
    {
        GetAllTeamsSortedAlphUserCase useCase = new();
        useCase.execute();
    }
}