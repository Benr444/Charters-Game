using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MaritimeState : TenetCard
{
    public MaritimeState() : base
    (
        cardName: "Maritime State",
        alignment: CharterCard.Alignment.BLACK,
        textBoxText: "As longs as all your towns are built adjacent to oceans or rivers, you have +4 victory points.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    )
    { }

    public override CharterCard Create()
    {
        return new MaritimeState();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
