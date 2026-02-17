using CsvHelper.Configuration;
using TRD_Analytics.Domain.Entities;

namespace TRD_Analytics.Application.Map;

public class MatchEntityMap : ClassMap<MatchEntity>
{
    public MatchEntityMap()
    {
        // Map by the exact header name in your CSV
        Map(m => m.Date).Name("date");
        Map(m => m.HomeTeam).Name("home_team");
        Map(m => m.AwayTeam).Name("away_team");
        Map(m => m.HomeScore).Name("home_score");
        Map(m => m.AwayScore).Name("away_score");
        Map(m => m.Tournament).Name("tournament");
        Map(m => m.City).Name("city");
        Map(m => m.Country).Name("country");
        Map(m => m.Neutral).Name("neutral");
    }
}