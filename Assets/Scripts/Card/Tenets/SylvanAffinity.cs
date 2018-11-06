using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SylvanAffinity : TenetCard
{
    public SylvanAffinity() : base
    (
        cardName: "Sylvan Affinity",
        alignment: CharterCard.Alignment.GREEN,
        textBoxText: "You have one additional victory points for every 2 forests in your territory.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new SylvanAffinity();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
