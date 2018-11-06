using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents town cards
public abstract class TownCard : MapCard
{
    public static readonly string TOWN_TYPE = "Town";

    protected int integrity;
    
    protected TownCard(string cardName, int manaCost, int integrity, Rarity rarity, Alignment alignment, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: manaCost, 
        rarity: rarity, 
        alignment: alignment, 
        textBoxText: textBoxText, 
        cardType: "Town", 
        artist: artist, 
        cardSet: cardSet
    )
    {
        this.integrity = integrity;
    }

    public override CharterCard Create()
    {
        throw new System.NotImplementedException();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
