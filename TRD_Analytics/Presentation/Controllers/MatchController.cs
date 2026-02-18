using TRD_Analytics.Application;
using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Models;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Presentation;

public static class MatchController
{
    public static List<MatchModel> GetAllMatches()
    {
        GetAllMatchesUseCase useCase = new(new MatchRepository());
        return useCase.Execute();
    }

    public static  List<MatchModel> GetAllTeamsMatches(string teamName)
    {
        GetAllTeamMatchUseCase useCase = new(new MatchRepository());
        return useCase.Execute(teamName);
    }
}