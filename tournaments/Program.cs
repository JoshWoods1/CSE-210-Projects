// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Player Michael = new Player("Michael","Jordan",23);
Michael.UpdateJersey(45);
Michael.UpdateJersey(23);

Michael.Display();

Player Axa = new Player("Axa", "Uribe", 10);

Team fireballs = new Team("Fireballs");
fireballs.AddPlayer(Axa);
fireballs.AddPlayer(Michael);
Team otherTeam = new Team("otherTeam");
fireballs.AddWin();
fireballs.AddLoss();
fireballs.AddWin();
fireballs.Display();

Match match1 = new Match(fireballs, otherTeam);
match1.DecideWin();
fireballs.Display();
otherTeam.Display();

