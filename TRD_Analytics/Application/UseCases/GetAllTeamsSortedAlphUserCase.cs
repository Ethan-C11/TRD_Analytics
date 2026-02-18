using TRD_Analytics.Application.DTO;
using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllTeamsSortedAlphUserCase
{
   private readonly ITeamRepository _teamRepository;
   private readonly IDisplayUseCase _displayUseCase;

   public GetAllTeamsSortedAlphUserCase(ITeamRepository teamRepository, IDisplayUseCase displayUseCase)
   {
      _teamRepository = teamRepository;
      _displayUseCase = displayUseCase;
   }
   public List<TeamDto> Execute()
   {
      return _teamRepository.GetTeams();
   }
}