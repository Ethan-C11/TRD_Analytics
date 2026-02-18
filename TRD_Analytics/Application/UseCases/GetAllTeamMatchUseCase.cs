using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Models;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllTeamMatchUseCase
{

    private readonly IMatchRepository _matchRepo;

    public GetAllTeamMatchUseCase(IMatchRepository matchRepo)
    {
        _matchRepo = matchRepo;
    }
    public List<MatchModel> Execute(string teamName)
    {
        teamName = teamName.ToUpper();
        var matches = _matchRepo.GetMatches();
        var teamMatches = matches.Where(m => m.HomeTeam.ToUpper() == teamName || m.AwayTeam.ToUpper() == teamName).ToList();
        
        return teamMatches;
    }
}