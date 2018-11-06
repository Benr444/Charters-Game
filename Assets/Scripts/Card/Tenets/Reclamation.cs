using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Reclamation : TenetCard
{
    public Reclamation() : base
    (
        cardName: "Reclamation",
        alignment: CharterCard.Alignment.GREEN,
        textBoxText: "Whenever you build on one of your ruins, gain 1 victory point.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new Reclamation();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
