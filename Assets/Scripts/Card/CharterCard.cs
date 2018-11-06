using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Represents cards
[ExecuteInEditMode]
public abstract class CharterCard : MonoBehaviour
{
    public static readonly uint COMMON_FREQUENCY = 3;

    public static readonly uint UNCOMMON_FREQUENCY = 2;

    public static readonly uint RARE_FREQUENCY = 1;

    public enum Alignment
    {
        BLUE,
        GREEN,
        BLACK,
        RED
    }

    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE
    }

    public enum CardSet
    {
        BASE
    }

    protected readonly Rarity rarity;
    protected readonly string cardName;
    protected readonly Alignment alignment;
    protected readonly string textBoxText;
    protected readonly string artist;
    protected readonly CardSet cardSet;
    protected readonly int manaCost;
    protected readonly string cardTypeString;

    protected bool isFaceUp;

    //CONSTRUCTOR
    protected CharterCard(string cardName, int manaCost, Rarity rarity, Alignment alignment, string textBoxText, string cardType, string artist, CardSet cardSet)
    {
        this.cardName = cardName;
        this.manaCost = manaCost;
        this.rarity = rarity;
        this.alignment = alignment;
        this.textBoxText = textBoxText;
        this.artist = artist;
        this.cardSet = cardSet;
        this.cardTypeString = cardType;
        this.isFaceUp = true;
    }

    //FACTORY METHOD
    public abstract CharterCard Create();

    public abstract bool Play(BuildManager bm);

    void Awake()
    {
        transform.Find("Front");
    }

    public uint GetFrequency()
    {
        if (rarity == Rarity.COMMON)
        {
            return COMMON_FREQUENCY;
        }
        else if (rarity == Rarity.UNCOMMON)
        {
            return UNCOMMON_FREQUENCY;
        }
        else if (rarity == Rarity.RARE)
        {
            return RARE_FREQUENCY;
        }
        else
        {
            Debug.Log("The rarity of a card was queried oddly. Returning 0 for frequency");
            return 0;
        }
    }

    public void SetFaceUp(bool faceUp)
    {
        this.isFaceUp = faceUp;
    }

    public bool GetFaceUp()
    {
        return this.isFaceUp;
    }


    public int GetManaCost()
    {
        return this.manaCost;
    }

    public string GetCardType()
    {
        return this.cardTypeString;
    }

    public string GetName()
    {
        return this.cardName;
    }

    public string GetArtist()
    {
        return this.artist;
    }

    public Rarity GetRarity()
    {
        return this.rarity;
    }

    public string GetTextBoxText()
    {
        return this.textBoxText;
    }

    public Alignment GetAlignment()
    {
        return this.alignment;
    }

    public CardSet GetCardSet()
    {
        return this.cardSet;
    }
}