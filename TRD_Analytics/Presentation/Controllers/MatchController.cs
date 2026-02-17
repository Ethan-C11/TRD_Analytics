using TRD_Analytics.Application;

namespace TRD_Analytics.Presentation;

public static class MatchController
{
    public static void GetAllMatches()
    {
        GetAllMatchesUseCase useCase = new();
        useCase.execute();
    }

    public static void GetAllTeamsMatches(string teamName)
    {
        GetAllTeamMatchUseCase useCase = new();
        useCase.execute(teamName);
    }
}