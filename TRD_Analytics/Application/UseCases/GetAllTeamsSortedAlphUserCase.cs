using TRD_Analytics.Presentation.Repository;

namespace TRD_Analytics.Application;

public class GetAllTeamsSortedAlphUserCase
{
   private readonly TeamRepository _teamRepository;
   private readonly DisplayUseCase _displayUseCase;

   public GetAllTeamsSortedAlphUserCase()
   {
      _teamRepository = new TeamRepository();
      _displayUseCase = new DisplayUseCase();
   }
   public void execute()
   {
      _displayUseCase.execute(_teamRepository.GetTeams());
   }
}