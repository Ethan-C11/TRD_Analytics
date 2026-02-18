using TRD_Analytics.Application;
using TRD_Analytics.Application.DTO;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Presentation;

public static class MatchController
{
    public static List<MatchDto> GetAllMatches()
    {
        GetAllMatchesUseCase useCase = new(new MatchRepository());
        return useCase.Execute();
    }

    public static  List<MatchDto> GetAllTeamsMatches(string teamName)
    {
        GetAllTeamMatchUseCase useCase = new(new MatchRepository());
        return useCase.Execute(teamName);
    }
}