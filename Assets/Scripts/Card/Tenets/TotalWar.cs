using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class TotalWar : TenetCard
{
    public TotalWar() : base
    (
        cardName: "Total War",
        alignment: CharterCard.Alignment.RED,
        textBoxText: "Whenever you destroy a town, gain 1 victory point.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new TotalWar();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
