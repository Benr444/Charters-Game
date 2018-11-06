using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

public static class CardLexicon
{
    //Card stored in the cardList function as "pseudo-factories" or "master copies" that can create new instances of themselves without reflection
    //DO NOT REGISTER TENETS HERE OR THEY WILL APPEAR IN DRAFTS
    public static readonly CharterCard[] cardList = new CharterCard[]
    {
        new Inquisitor(),
        new ArcaneLibrary(),
        new BasicTown()
    };
}
