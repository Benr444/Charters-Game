using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents cards that can become attached to other cards
public abstract class ImprovementCard : BoardCard
{
    protected ImprovementCard(string cardName, int manaCost, Rarity rarity, Alignment alignment, string cardType, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: manaCost, 
        rarity: rarity, 
        alignment: alignment,
        textBoxText: textBoxText, 
        cardType: cardType, 
        artist: artist, 
        cardSet: cardSet
    ) { }
}
