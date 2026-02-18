using TRD_Analytics.Application.DTO;

namespace TRD_Analytics.Presentation.Repository;

public interface IMatchRepository
{
    List<MatchDto> GetMatches();
}