using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cards
{
    //Uses the "master copy" design pattern
    //This class is really just a factory for UnitCards with particular attributes
    //PLUS the very important implementation of the play function
    public sealed class BasicTown : TownCard
    {
        //It looks silly, but what's going on here is that this method just passes a bunch of stuff into the base/parent class constructor
        public BasicTown() : base
        (
            cardName: "Town",
            manaCost: 4,
            integrity: 15,
            rarity: CharterCard.Rarity.COMMON,
            alignment: CharterCard.Alignment.BLUE,
            textBoxText: "Play on a tile adjacent to a unit you control. Place a ruin when this is destroyed.",
            artist: "N/A",
            cardSet: CharterCard.CardSet.BASE
        )
        { }

        //Factory method
        override public CharterCard Create()
        {
            return new BasicTown();
        }

        public override bool Play(BuildManager bm)
        {
            throw new System.NotImplementedException();
        }
    }
}