using System;
using System.Collections.Generic;

public class Dough
{
    private static readonly Dictionary<string, decimal> FlourModifiers = new()
    {
        { "white", 1.5m },
        { "wholegrain", 1.0m }
    };
    private static readonly Dictionary<string, decimal> BakingModifiers = new()
    {
        { "crispy", 0.9m },
        { "chewy", 1.1m },
        { "homemade", 1.0m }
    };
    private string flourType;
    private string bakingTechnique;
    private int weight;
    public Dough(string flourType, string bakingTechnique, int weight)
    {
        FlourType = flourType.ToLower();
        BakingTechnique = bakingTechnique.ToLower();
        Weight = weight;
    }
    public string FlourType
    {
        get => flourType;
        private set
        {
            if (!FlourModifiers.ContainsKey(value))
                throw new ArgumentException("Invalid type of dough.");
            flourType = value;
        }
    }
    public string BakingTechnique
    {
        get => bakingTechnique;
        private set
        {
            if (!BakingModifiers.ContainsKey(value))
                throw new ArgumentException("Invalid type of dough.");
            bakingTechnique = value;
        }
    }
    public int Weight
    {
        get => weight;
        private set
        {
            if (value < 1 || value > 200)
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            weight = value;
        }
    }
    public decimal Calories => 2 * weight * FlourModifiers[flourType] * BakingModifiers[bakingTechnique];
}