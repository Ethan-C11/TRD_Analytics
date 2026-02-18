using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Entities;
using TRD_Analytics.Domain.Models;

namespace TRD_Analytics.Application.Map;

public static class MatchMappingExtensions
{
    public static MatchModel ToDto(this MatchEntity entity)
    {
        if (entity == null) return null;

        return new MatchModel
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
    
    public static List<MatchModel> ToDtoList(this IEnumerable<MatchEntity> entities)
    {
        if (entities == null) return new List<MatchModel>();
        
        return entities
            .Select(e => e.ToDto())
            .ToList();
    }
}