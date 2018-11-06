using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents cards that improve units
public abstract class UnitImprovementCard : ImprovementCard
{
    public static readonly string UNIT_IMPROVEMENT_TYPE = "Unit Improvement";

    protected int powerModifier;

    protected int hpModifier;

    protected UnitImprovementCard(string cardName, int manaCost, Rarity rarity, Alignment alignment, string cardType, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: manaCost, 
        rarity: rarity, 
        alignment: alignment, 
        cardType: UNIT_IMPROVEMENT_TYPE, 
        textBoxText: textBoxText, 
        artist: artist, 
        cardSet: cardSet
    ) { }
}
