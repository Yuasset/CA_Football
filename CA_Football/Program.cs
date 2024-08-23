using CA_Football;

Random random = new Random();
Team team = new Team();

team.TeamName = "Trabzonspor";
team.TeamColor = "Bordo-Mavi";
team.TeamSize = 11;

Keeper keeper = new Keeper();
keeper.Name = "Uğurcan Çakır";
team.Player = keeper;

Striker striker1 = new Striker();
striker1.Name = "Alexander Sörloth";
team.Player = striker1;

Striker striker2 = new Striker();
striker2.Name = "Caleb Ekuban";
team.Player = striker2;

Striker striker3 = new Striker();
striker3.Name = "Anthony Nwakaeme";
team.Player = striker3;

Midfield midfield1 = new Midfield();
midfield1.Name = "Jose Sosa";
team.Player = midfield1;

Midfield midfield2 = new Midfield();
midfield2.Name = "Abdülkadir Ömür";
team.Player = midfield2;

Midfield midfield3 = new Midfield();
midfield3.Name = "Flavio";
team.Player = midfield3;

Midfield midfield4 = new Midfield();
midfield4.Name = "Obi Mikel";
team.Player = midfield4;

Defender defender1 = new Defender();
defender1.Name = "Hüseyin Türkmen";
team.Player = defender1;

Defender defender2 = new Defender();
defender2.Name = "Kamil Ahmet Çörekçi";
team.Player = defender2;

Defender defender3 = new Defender();
defender3.Name = "Gastón Campi";
team.Player = defender3;

List<Team> teams = new List<Team>();
teams.Add(team);
List<Player> players = new List<Player>();
players.Add(keeper);
players.Add(striker1);
players.Add(striker2);
players.Add(striker3);
players.Add(midfield1);
players.Add(midfield2);
players.Add(midfield3);
players.Add(midfield4);
players.Add(defender1);
players.Add(defender2);
players.Add(defender3);


foreach (Team item in teams)
{
    Console.WriteLine("Takım: "+item.TeamName);
    Console.WriteLine("Takım Rengi: "+ item.TeamColor);
    Console.WriteLine("Oyuncu Sayısı: " + item.TeamSize);
}

Console.WriteLine("Oyuncular:");
foreach (Player item in players)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("Oyun:");
foreach (Player item in players)
{
    Console.WriteLine("Oyuncu: "+item.Name);
    Console.WriteLine("Koşma: "+item.Run(random.Next(1, 101)));
    Console.WriteLine("Şut: "+item.Shoot(random.Next(1, 101)));
    Console.WriteLine("Çalım: "+item.Feint(random.Next(1, 101)));
    Console.WriteLine("Press: "+item.Pressing(random.Next(1, 101)));
    Console.WriteLine();
}
    Console.WriteLine("Oyuncu: "+keeper.Name);
    Console.WriteLine(keeper.SaveBall(random.Next(1, 101)));