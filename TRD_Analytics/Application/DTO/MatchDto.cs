namespace TRD_Analytics.Application.DTO;

public class MatchDto
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
}