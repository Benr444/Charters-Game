using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TenetCard : CharterCard
{
    public static readonly CharterCard.Rarity TENET_RARITY = CharterCard.Rarity.RARE;

    public static readonly string TENET_TYPE = "Tenet";

    public static int TENET_MANA_COST = 0;

    protected TenetCard(string cardName, Alignment alignment, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: TENET_MANA_COST, 
        rarity: TENET_RARITY, 
        alignment: alignment, 
        textBoxText: textBoxText, 
        cardType: TENET_TYPE, 
        artist: artist, 
        cardSet: cardSet
    ) { }
}
