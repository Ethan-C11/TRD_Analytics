using Moq;
using TRD_Analytics.Application;
using TRD_Analytics.Application.DTO;
using TRD_Analytics.Domain.Models;
using TRD_Analytics.Presentation.Repository;

[TestClass]
public class UseCaseTests
{
    private Mock<IMatchRepository> _matchRepoMock;
    private Mock<ITeamRepository> _teamRepoMock;

    [TestInitialize]
    public void Setup()
    {
        _matchRepoMock = new Mock<IMatchRepository>();
        _teamRepoMock = new Mock<ITeamRepository>();
    }

    [TestMethod]
    public void GetAllMatchesUseCase_ShouldReturnCorrectList()
    {
        var expectedMatches = new List<MatchModel> 
        { 
            new MatchModel { HomeTeam = "France", AwayTeam = "Italie" } 
        };
        
        _matchRepoMock.Setup(r => r.GetMatches()).Returns(expectedMatches);
        
        var useCase = new GetAllMatchesUseCase(_matchRepoMock.Object);

        var result = useCase.Execute();

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual("France", result[0].HomeTeam);
    }

    [TestMethod]
    public void GetAllTeamMatchUseCase_ShouldFilterByTeamName()
    {
        var allMatches = new List<MatchModel> 
        { 
            new MatchModel { HomeTeam = "PSG", AwayTeam = "OM" },
            new MatchModel { HomeTeam = "LENS", AwayTeam = "Lyon" }
        };
        _matchRepoMock.Setup(r => r.GetMatches()).Returns(allMatches);
        var useCase = new GetAllTeamMatchUseCase(_matchRepoMock.Object);

        var result = useCase.Execute("psg");
        
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.Any(m => m.HomeTeam == "PSG" || m.AwayTeam == "PSG"));
    }

    [TestMethod]
    public void GetAllTeamsSortedAlphUserCase_ShouldReturnList()
    {
        var teams = new List<TeamDto> 
        { 
            new TeamDto("Arsenal"), 
            new TeamDto("Chelsea") 
        };
        _teamRepoMock.Setup(r => r.GetTeams()).Returns(teams);
        
        var useCase = new GetAllTeamsSortedAlphUserCase(_teamRepoMock.Object);

        var result = useCase.Execute();

        Assert.AreEqual(2, result.Count);
        _teamRepoMock.Verify(r => r.GetTeams(), Times.Once);
    }
}