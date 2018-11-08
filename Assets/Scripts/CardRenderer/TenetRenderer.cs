using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenetRenderer : CharterCardRenderer<TenetCard>
{
    //This class actually removes some functionality from the CharterCardRenderer
    //There is no sub-GameObject for mana cost on the prefab this is attached to
    public override void Update()
    {
        base.Update();
        this.manaCostText = null;
    }
}
