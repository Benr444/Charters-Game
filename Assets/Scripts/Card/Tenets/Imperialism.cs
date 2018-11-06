using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Imperialism : TenetCard
{
    public Imperialism() : base
    (
        cardName: "Imperialism",
        alignment: CharterCard.Alignment.RED,
        textBoxText: "As long as you control the most territory, you have +3 victory points.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    )
    { }

    public override CharterCard Create()
    {
        return new Imperialism();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
