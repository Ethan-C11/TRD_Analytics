using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Models;

namespace TRD_Analytics.Presentation.Repository;

public interface IMatchRepository
{
    List<MatchModel> GetMatches();
}