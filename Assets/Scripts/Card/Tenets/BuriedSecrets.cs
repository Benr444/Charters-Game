using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BuriedSecrets : TenetCard
{
    public BuriedSecrets() : base
    (
        cardName: "Buried Secrets",
        alignment: CharterCard.Alignment.BLUE,
        textBoxText: "Once per turn you may discard 3 cards to gain 1 victory point.",
        artist: "N/A",
        cardSet: CharterCard.CardSet.BASE
    ) { }

    public override CharterCard Create()
    {
        return new BuriedSecrets();
    }

    public override bool Play(BuildManager bm)
    {
        throw new System.NotImplementedException();
    }
}
