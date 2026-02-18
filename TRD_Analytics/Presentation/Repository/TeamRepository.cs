using TRD_Analytics.Application.DTO;
using TRD_Analytics.Application.Map;
using TRD_Analytics.Domain.Entities;
using TRD_Analytics.Infrastructure.Database;

namespace TRD_Analytics.Presentation.Repository;

public class TeamRepository : ITeamRepository
{
    private readonly List<MatchEntity> _matches;
    public TeamRepository()
    {
        _matches = ParseData.ParseMatchEntities("C:\\Users\\ethan\\Documents\\mns\\m2i\\clean_architecture\\td_trd_analytics\\TRD_Analytics\\TRD_Analytics\\Infrastructure\\Database\\data.csv");
    }

    public List<TeamDto> GetTeams()
    {
        var homeTeams = _matches.Select(m => m.HomeTeam).Distinct().ToList();
        var awayTeams = _matches.Select(m => m.AwayTeam).Distinct().ToList();
        
        var allTeams = homeTeams.Union(awayTeams).Distinct().ToList().OrderBy(t => t).Select(t => new TeamDto(t)).ToList();
        return allTeams;
    }
}