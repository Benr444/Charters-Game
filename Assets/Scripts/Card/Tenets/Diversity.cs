using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Diversity : TenetCard
{
    public Diversity() : base
    (
        cardName: "Diversity",
        alignment: CharterCard.Alignment.BLUE,
        textBoxText: "As long as you have a town on each of Ocean, Mountain, Hill, Forest, River, and Fields tiles, you have +5 victory points.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new Diversity();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
