using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Cultivation : TenetCard
{
    public Cultivation() : base
    (
        cardName: "Cultivation",
        alignment: CharterCard.Alignment.GREEN,
        textBoxText: "Once per turn, you may pay 7 mana to gain 1 victory point.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new Cultivation();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
