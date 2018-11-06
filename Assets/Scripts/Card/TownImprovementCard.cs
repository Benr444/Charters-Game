using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Representes town improvement cards
public abstract class TownImprovementCard : ImprovementCard
{
    public static readonly string TOWN_IMPROVEMENT_TYPE = "Town Improvement";

    protected int integrityModifier;
    
    protected TownImprovementCard(string cardName, int manaCost, int integModifier, Rarity rarity, Alignment alignment, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: manaCost, 
        rarity: rarity, 
        alignment: alignment, 
        textBoxText: textBoxText, 
        cardType: TOWN_IMPROVEMENT_TYPE, 
        artist: artist, 
        cardSet: cardSet
    )
    {
        this.integrityModifier = integModifier;
    }
}
