using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DynasticState : TenetCard
{
    public DynasticState() : base
    (
        cardName: "Dynastic State",
        alignment: CharterCard.Alignment.RED,
        textBoxText: "Whenever you build on an opponent's ruins, gain 1 victory point.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new DynasticState();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
