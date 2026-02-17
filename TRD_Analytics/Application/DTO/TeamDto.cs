namespace TRD_Analytics.Application.DTO;

public class TeamDto
{
    public string TeamName { get; set; }

    public TeamDto(string teamName)
    {
        TeamName = teamName;
    }
}