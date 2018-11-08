using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public abstract class CharterCardRenderer<T> : MonoBehaviour where T : CharterCard
{
    public T cardData;

    public Text manaCostText;
    public Text typeText;
    public Text nameText;
    public Text metadataText;
    public Text textBoxText;

    public virtual void Update()
    {
        manaCostText.text = "" + cardData.GetManaCost();
        typeText.text = "" + cardData.GetCardType();
        nameText.text = "" + cardData.GetName();
        textBoxText.text = "" + cardData.GetTextBoxText();
        metadataText.text = "art:" + cardData.GetArtist() + " set:" + cardData.GetCardSet();
    }
}
