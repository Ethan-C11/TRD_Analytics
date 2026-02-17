using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllMatchesUseCase
{

    private readonly MatchRepository _matchRepo;
    private readonly DisplayUseCase _displayUseCase;
    public GetAllMatchesUseCase()
    {
        _matchRepo = new MatchRepository();
        _displayUseCase = new DisplayUseCase();
    }
    public void execute()
    {
        _displayUseCase.execute(_matchRepo.GetMatches());
    }
}