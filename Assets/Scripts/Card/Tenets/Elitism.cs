using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Elitism : TenetCard
{
    public Elitism() : base
    (
        cardName: "Elitism",
        alignment: CharterCard.Alignment.BLACK,
        textBoxText: "As long as you control 8 or more victory points, you have +3 victory points.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    )
    { }

    public override CharterCard Create()
    {
        return new Elitism();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
