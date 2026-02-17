using TRD_Analytics.Presentation;

static int AfficherMenu(string titre, string[] options)
{
    int index = 0;
    ConsoleKey touche;
    Console.CursorVisible = false;

    do
    {
        Console.Clear();
        Console.WriteLine($"--- {titre} ---");
        Console.WriteLine("(Utilisez les flèches ↑↓ et Entrée)\n");

        for (int i = 0; i < options.Length; i++)
        {
            if (i == index)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" > {options[i]} ");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"   {options[i]} ");
            }
        }

        touche = Console.ReadKey(true).Key;

        if (touche == ConsoleKey.UpArrow) 
            index = (index == 0) ? options.Length - 1 : index - 1;
        else if (touche == ConsoleKey.DownArrow) 
            index = (index == options.Length - 1) ? 0 : index + 1;

    } while (touche != ConsoleKey.Enter);

    Console.CursorVisible = true;
    return index;
}

string[] menuPrincipal = { 
    "Lister tous les matchs", 
    "Lister toutes les équipes", 
    "Lister tous les matchs d'une équipe", 
    "Quitter l'application" 
};

bool continuer = true;

while (continuer)
{
    int choix = AfficherMenu("GESTION DES MATCHS", menuPrincipal);

    Console.Clear();
    switch (choix)
    {
        case 0: 
            MatchController.GetAllMatches();
            break;
        case 1: 
            TeamController.GetAllTeams();
            break;
        case 2: 
            Console.Write("Veuillez entrer le nom de l'équipe : ");
            string teamName = Console.ReadLine();
            MatchController.GetAllTeamsMatches(teamName);
            break;
        case 3: 
            continuer = false;
            Console.WriteLine("Au revoir !");
            break;
    }

    if (continuer && choix != 3)
    {
        Console.WriteLine("\nAppuyez sur une touche pour revenir au menu...");
        Console.ReadKey();
    }
}