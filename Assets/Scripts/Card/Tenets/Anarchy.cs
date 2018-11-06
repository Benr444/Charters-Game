using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Anarchy : TenetCard
{
    public Anarchy() : base
    (
        cardName: "Anarchy",
        alignment: CharterCard.Alignment.BLACK,
        textBoxText: "No text yet...",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    )
    { }

    public override CharterCard Create()
    {
        return new Anarchy();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
