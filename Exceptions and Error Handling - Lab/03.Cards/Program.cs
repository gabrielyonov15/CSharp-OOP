using System;
using System.Collections.Generic;
class Card
{
    private string face;
    private string suit;
    private static readonly HashSet<string> validFaces = new HashSet<string>
        { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private static readonly Dictionary<string, string> validSuits = new Dictionary<string, string>
    {
        { "S", "\u2660" }, 
        { "H", "\u2665" }, 
        { "D", "\u2666" }, 
        { "C", "\u2663" }  
    };
    public Card(string face, string suit)
    {
        if (!validFaces.Contains(face) || !validSuits.ContainsKey(suit))
        {
            throw new ArgumentException("Invalid card!");
        }
        this.face = face;
        this.suit = validSuits[suit];
    }
    public override string ToString()
    {
        return $"[{face}{suit}]";
    }
}
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cardStrings = input.Split(", ");
        List<string> cards = new List<string>();
        foreach (string cardString in cardStrings)
        {
            try
            {
                string[] parts = cardString.Split(' ');
                string face = parts[0];
                string suit = parts[1];
                Card card = new Card(face, suit);
                cards.Add(card.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid card!");
            }
        }
        Console.WriteLine(string.Join(" ", cards));
    }
}