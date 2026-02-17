using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllTeamMatchUseCase
{

    private readonly MatchRepository _matchRepo;
    private readonly DisplayUseCase _displayUseCase;

    public GetAllTeamMatchUseCase()
    {
        _matchRepo = new MatchRepository();
        _displayUseCase = new DisplayUseCase();
    }
    public void execute(string teamName)
    {
        teamName = teamName.ToUpper();
        var matches = _matchRepo.GetMatches();
        var teamMatches = matches.Where(m => m.HomeTeam.ToUpper() == teamName || m.AwayTeam.ToUpper() == teamName).ToList();
        
        _displayUseCase.execute(teamMatches);
    }
}