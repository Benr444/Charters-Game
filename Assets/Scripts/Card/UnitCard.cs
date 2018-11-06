using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents unit cards
public abstract class UnitCard : MapCard
{
    public static readonly string UNIT_TYPE = "Unit";

    protected int power;

    protected int hp;

    public UnitCard(string cardName, int manaCost, int power, int hp, Rarity rarity, Alignment alignment, string textBoxText, string artist, CardSet cardSet)
    : base
    (
        cardName: cardName, 
        manaCost: manaCost, 
        rarity: rarity, 
        alignment: alignment, 
        cardType: UNIT_TYPE,
        textBoxText: textBoxText, 
        artist: artist, 
        cardSet: cardSet
    )
    {
        this.power = power;
        this.hp = hp;
    }
}
