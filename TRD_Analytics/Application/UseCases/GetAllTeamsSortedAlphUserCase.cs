using TRD_Analytics.Application.DTO;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllTeamsSortedAlphUserCase
{
   private readonly ITeamRepository _teamRepository;

   public GetAllTeamsSortedAlphUserCase(ITeamRepository teamRepository )
   {
      _teamRepository = teamRepository;
   }
   public List<TeamDto> Execute()
   {
      return _teamRepository.GetTeams();
   }
}