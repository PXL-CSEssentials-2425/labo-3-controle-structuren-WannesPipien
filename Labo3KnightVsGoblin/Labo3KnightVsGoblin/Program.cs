using System.ComponentModel.Design;
using System.Diagnostics;

Random randomNumberGenerator = new Random();

int attackKnight = 10;
int healKnight = 10;
int attackGoblin = 5;
int knightHealth;
Console.Write("What's the knight's health?: ");
string input = Console.ReadLine();

bool isValidNumber = int.TryParse(input, out knightHealth);
if(isValidNumber == true)
{
    if(knightHealth <= 0 || knightHealth > 100)
    {
        //ongeldeige input, standart waarde 100 in gebruik
        Console.WriteLine("Nummer must be between 0 and 100, default valuse is used.");
        knightHealth = 100;
    }
}
else
{
    Console.WriteLine("Invalid input, default valuse 100 is used.");
    knightHealth = 100;
}
int goblinHealth = randomNumberGenerator.Next(20, 100);

Console.WriteLine($"Knight health: {knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");

do
{
    Console.WriteLine("Availabe actions:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.Write("Please select an action. ");
    string action = Console.ReadLine();

    switch (action)
    {
        case "1":
            goblinHealth -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("attacked ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"the goblin for {attackKnight} hp.");
            Console.ResetColor();
            break;
        case "2":
            knightHealth += healKnight;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You drank a potion,");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("healing ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"you for for {healKnight} hp.");
            Console.ResetColor();
            break;
        default:
            Console.WriteLine("Dit is geen geldige input.");
            break;
    }

    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("You where ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("attacked ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"by the goblin for {attackGoblin} hp.");
        Console.ResetColor();
    }

    if (knightHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The knight has fallen to a lowly goblin...you lost");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"knight health: {knightHealth}");
        Console.ResetColor();
    }

    if (goblinHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The knight has slain the goblin and continues on his quest.");
        Console.ResetColor();
    }
    //Loop stops when either knight or goblin dies
} while (knightHealth > 0 && goblinHealth > 0);


/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
