using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownRenderer : CharterCardRenderer<TownCard>
{
    public Text powerText;
    public Text hpText;

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        hpText.text = "" + cardData.GetHP();
        powerText.text = "" + cardData.GetPower();
    }
}
