// See https://aka.ms/new-console-template for more information


using TRD_Analytics.Application;
using TRD_Analytics.Presentation;

string input = "";


while(input != "q") {
    Console.WriteLine("Veuillez choisir l'opération à effectuer");
    Console.WriteLine("1 : Lister tout les matchs");
    Console.WriteLine("2 : Lister toutes les équipes");
    Console.WriteLine("3 : Lister tout les matchs d'une équipe");
    Console.WriteLine("q : Quitter l'application");
    input = Console.ReadLine();
    Console.Clear();
    switch (input)
    {
        case "1":
            MatchController.GetAllMatches();
            break;
        case "2":
            TeamController.GetAllTeams();
            break;
        case "3":
            Console.WriteLine("Veuillez entrer le nom de l'équipe");
            string teamName = Console.ReadLine();
            MatchController.GetAllTeamsMatches(teamName);
            break;
        case "q":
            return;
        default:
            Console.Clear();
            Console.WriteLine("Input invalide.");
            break;
    }
} 

