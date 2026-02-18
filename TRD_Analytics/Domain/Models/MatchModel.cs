namespace TRD_Analytics.Domain.Models;

public record MatchModel
{
    public DateOnly Date { get; set; }
    public string HomeTeam { get; set; }
    public string AwayTeam { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public string Tournament { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public bool Neutral { get; set; }
    
    public int TotalGoals => HomeScore + AwayScore;
    
    public bool IsDraw => HomeScore == AwayScore;

    public string Winner => IsDraw ? "DRAW" : (HomeScore > AwayScore ? HomeTeam : AwayTeam);

    public string Loser => IsDraw ? "DRAW" : (HomeScore < AwayScore ? HomeTeam : AwayTeam);
    
    public bool IsWonBy(string teamName)
    {
        return string.Equals(Winner, teamName.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    public bool Involves(string teamName)
    {
        var normalized = teamName.Trim();
        return string.Equals(HomeTeam, normalized, StringComparison.OrdinalIgnoreCase) ||
               string.Equals(AwayTeam, normalized, StringComparison.OrdinalIgnoreCase);
    }
}