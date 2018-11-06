using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

public static class TenetLexicon
{
    //Card stored in the cardList function as "pseudo-factories" or "master copies" that can create new instances of themselves without reflection
    public static readonly TenetCard[] tenetList = new TenetCard[]
    {
        new Anarchy(),
        new BuriedSecrets(),
        new Cultivation(),
        new Diversity(),
        new DynasticState(),
        new Elitism(),
        new Imperialism(),
        new MaritimeState(),
        new MartialState(),
        new Oligarchy(),
        new Reclamation(),
        new SylvanAffinity(),
        new TotalWar()
    };
}
