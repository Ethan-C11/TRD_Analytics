using TRD_Analytics.Application.DTO;

namespace TRD_Analytics.Presentation.Repository;

public interface ITeamRepository
{
    List<TeamDto> GetTeams();
}