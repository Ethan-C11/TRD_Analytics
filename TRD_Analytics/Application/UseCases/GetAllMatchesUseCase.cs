using TRD_Analytics.Application.DTO;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllMatchesUseCase
{

    private readonly IMatchRepository _matchRepo;
    public GetAllMatchesUseCase(IMatchRepository matchRepo)
    {
        _matchRepo = matchRepo;
    }
    public List<MatchDto> Execute()
    {
        return _matchRepo.GetMatches();
    }
}