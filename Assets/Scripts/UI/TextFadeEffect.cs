using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeEffect : MonoBehaviour
{
    public float frequency;

    public float min;

    public float max;

    // Use this for initialization
    void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
        float scaleFactor = (Mathf.Sin(2 * Mathf.PI * Time.time * frequency) + 1) / 2;
        float newAlpha = min + ((max - min) * scaleFactor);
        Debug.Log("newAlpha: " + newAlpha);
        GetComponent<Text>().color = new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, newAlpha);
    }
}
