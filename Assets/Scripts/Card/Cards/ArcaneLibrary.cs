using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cards
{
    //Uses the "master copy" design pattern
    //This class is really just a factory for UnitCards with particular attributes
    //PLUS the very important implementation of the play function
    public sealed class ArcaneLibrary : TownImprovementCard
    {
        //It looks silly, but what's going on here is that this method just passes a bunch of stuff into the base/parent class constructor
        public ArcaneLibrary() : base
        (
            cardName: "Arcane Library",
            manaCost: 4,
            integModifier: 0,
            rarity: CharterCard.Rarity.COMMON,
            alignment: CharterCard.Alignment.BLUE,
            textBoxText: "At the start of this town's turn, its controller draws an extra turn.",
            artist: "N/A",
            cardSet: CharterCard.CardSet.BASE
        )
        { }

        //Factory method
        override public CharterCard Create()
        {
            return new ArcaneLibrary();
        }

        public override bool Play(BuildManager bm)
        {
            throw new System.NotImplementedException();
        }
    }
}