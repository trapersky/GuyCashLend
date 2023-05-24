// See https://aka.ms/new-console-template for more information
using GuyCashLend;

Guy Jacek = new Guy() { Cash = 50, Name = "Jacek" };
Guy Bartek = new Guy() { Cash = 100, Name = "Bartek" };

while (true)
{
    Jacek.WriteMyInfo();
    Bartek.WriteMyInfo();

    Console.Write("Podaj kwotę: ");
    string HowMuch = Console.ReadLine();
    if (HowMuch == " ") return;
    if (int.TryParse(HowMuch, out int amount))
    {
        Console.Write("Pieniądze ma przekazać: ");
        string WhichGuy = Console.ReadLine();
        if (WhichGuy == "Jacek")
        {
            int CashGiven = Jacek.GiveCash(amount);
            Bartek.ReceiveCash(CashGiven);
        }
        else if (WhichGuy == "Bartek")
        {
            int CashGiven = Bartek.GiveCash(amount);
            Jacek.ReceiveCash(amount);
        }
        else 
        {
            Console.WriteLine("Wpisz Jacek lub Bartek");
        }
    }
    else
    {
        Console.WriteLine("Wpisz kwotę (lub pusty wiersz, aby zakończyć).");
    }
} 