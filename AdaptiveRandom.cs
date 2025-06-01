using System.Collections.Generic;
using System;
using System.Linq;

public class AdaptiveRandom<T>
{
    private Dictionary<T, int> choices = new();
    private Random random = new();

    public void AddChoice(T item, int weight = 1)
    {
        if (choices.ContainsKey(item))
            choices[item] += weight;
        else
            choices[item] = weight;
    }

    public T GetNext()
    {
        int totalWeight = choices.Values.Sum();
        int randomValue = random.Next(totalWeight);
        int cumulativeWeight = 0;

        foreach (var choice in choices)
        {
            cumulativeWeight += choice.Value;
            if (randomValue < cumulativeWeight)
                return choice.Key;
        }

        throw new InvalidOperationException("No choices available.");
    }

    public void AdjustWeight(T item, int change)
    {
        if (choices.ContainsKey(item))
            choices[item] = Math.Max(1, choices[item] + change); // Ağırlık en az 1 olsun
    }
}
