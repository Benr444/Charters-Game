using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CharterCardRenderer : MonoBehaviour
{
    public CharterCard cardData;

    public Text manaCostText;
    public Text typeText;
    public Text nameText;
    public Text metadataText;
    public Text textBoxText;

    public float rotateFrequency;

    private Vector3 initialPos;

    // Use this for initialization
    void Awake()
    {
        initialPos = transform.position;
	}

    void Update()
    {
        if (Application.isPlaying)
        {
            transform.RotateAround(transform.position, transform.up, 360 * rotateFrequency * Time.deltaTime);
            transform.position = initialPos + new Vector3(Mathf.Cos(Time.time), Mathf.Sin(Time.time), 0);
        }

        manaCostText.text = "" + cardData.GetManaCost();
        typeText.text = "" + cardData.GetCardType();
        nameText.text = "" + cardData.GetName();
        textBoxText.text = "" + cardData.GetTextBoxText();
        metadataText.text = "art:" + cardData.GetArtist() + " set:" + cardData.GetCardSet();
    }

    public static void CreateCardObject(CharterCard cardData)
    {

    }
}
