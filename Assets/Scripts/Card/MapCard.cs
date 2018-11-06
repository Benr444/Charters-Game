using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents cards that require figurines on the map
public abstract class MapCard : BoardCard
{
    protected MapCard(string cardName, int manaCost, Rarity rarity, Alignment alignment, string cardType, string textBoxText, string artist, CardSet cardSet)
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
