using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class VerticalPercentFont : MonoBehaviour
{
    public float percentOfVerticalHeight;

    //Stores the last checked font size
    private int lastFontSize;

    //Stores the last checked percentOfVerticalHeight
    private float lastPHeight;

    // Use this for initialization
    void Update()
    {
        if (lastPHeight != percentOfVerticalHeight)
        {
            GetComponent<Text>().fontSize = (int)((percentOfVerticalHeight / 100) * Screen.height);
        }

        lastPHeight = percentOfVerticalHeight;
    }
}
