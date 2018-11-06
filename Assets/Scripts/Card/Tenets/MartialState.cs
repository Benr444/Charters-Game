using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MartialState : TenetCard
{
    public MartialState() : base
    (
        cardName: "Martial State",
        alignment: CharterCard.Alignment.RED,
        textBoxText: "You have X additional victory points, where X is the number of units you control minus one.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new MartialState();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
