using TRD_Analytics.Application.DTO;
using TRD_Analytics.Application.Map;
using TRD_Analytics.Domain.Entities;
using TRD_Analytics.Domain.Models;
using TRD_Analytics.Infrastructure.Database;

namespace TRD_Analytics.Presentation.Repository;

public class MatchRepository : IMatchRepository
{
    private readonly List<MatchEntity> _matches;
    public MatchRepository()
    {
        _matches = ParseData.ParseMatchEntities("C:\\Users\\ethan\\Documents\\mns\\m2i\\clean_architecture\\td_trd_analytics\\TRD_Analytics\\TRD_Analytics\\Infrastructure\\Database\\data.csv");
    }

    public List<MatchModel> GetMatches()
    {
        return _matches.ToDtoList();
    }
}