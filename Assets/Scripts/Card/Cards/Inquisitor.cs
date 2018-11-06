using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cards
{
    //Uses the "master copy" design pattern
    //This class is really just a factory for UnitCards with particular attributes
    //PLUS the very important implementation of the play function
    public sealed class Inquisitor : UnitCard
    {
        //It looks silly, but what's going on here is that this method just passes a bunch of stuff into the base/parent class constructor
        public Inquisitor() : base
        (
            cardName: "Inquisitor",
            power: 2,
            hp: 4,
            manaCost: 3,
            rarity: CharterCard.Rarity.COMMON,
            alignment: CharterCard.Alignment.RED,
            textBoxText: "Feared across the land.",
            artist: "N/A",
            cardSet: CharterCard.CardSet.BASE
        )
        { }

        //Factory method
        override public CharterCard Create()
        {
            return new Inquisitor();
        }

        public override bool Play(BuildManager bm)
        {
            //The rest of the shit
            throw new System.NotImplementedException();
        }
    }
}