using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Oligarchy : TenetCard
{
    public Oligarchy() : base
    (
        cardName: "Oligarchy",
        alignment: CharterCard.Alignment.BLUE,
        textBoxText: "As long as each your towns have the same number of improvements, you have +3 victory points (1 improvement minimum.)",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new Oligarchy();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
