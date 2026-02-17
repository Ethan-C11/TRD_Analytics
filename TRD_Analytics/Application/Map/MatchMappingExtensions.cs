using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Entities;
namespace TRD_Analytics.Application.Map;

public static class MatchMappingExtensions
{
    public static MatchDto ToDto(this MatchEntity entity)
    {
        if (entity == null) return null;

        return new MatchDto
        {
            Date = entity.Date,
            HomeTeam = entity.HomeTeam,
            AwayTeam = entity.AwayTeam,
            HomeScore = entity.HomeScore,
            AwayScore = entity.AwayScore,
            Tournament = entity.Tournament,
            City = entity.City,
            Country = entity.Country,
            Neutral = entity.Neutral
        };
    }
    
    public static List<MatchDto> ToDtoList(this IEnumerable<MatchEntity> entities)
    {
        if (entities == null) return new List<MatchDto>();
        
        return entities
            .Select(e => e.ToDto())
            .ToList();
    }
}