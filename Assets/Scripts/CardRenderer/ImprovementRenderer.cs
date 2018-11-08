using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImprovementRenderer : CharterCardRenderer<ImprovementCard>
{
    public Text addedPowerText;
    public Text addedHPText;

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        addedHPText.text = "+0";
        addedPowerText.text = "+0";
    }
}
