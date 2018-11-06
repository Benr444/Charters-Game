using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cards;

public class DraftManager : MonoBehaviour, CharterManager
{
    public static readonly string SCENE_NAME = "CardDraft";

    public static readonly uint TENET_DRAW_OPTIONS = 12;

    public bool makeCard;

    public GameObject targetObject;

    private CardPile<TenetCard> initialTenetPile;

    private CardPile<TenetCard> rejectedTenetPile;

    void Start()
    {
        BeginTenetDraft();
    }

    void Update()
    {
        if (makeCard)
        {
            makeCard = false;
            GameObject newCard = Instantiate(targetObject);
            newCard.AddComponent<Inquisitor>();
            newCard.GetComponent<CharterCardRenderer>().cardData = new Inquisitor();
        }
    }

    private void BeginTenetDraft()
    {
        //Initialize the tenet piles
        initialTenetPile = new CardPile<TenetCard>();
        rejectedTenetPile = new CardPile<TenetCard>();

        //Populate the tenet list
        foreach (TenetCard c in TenetLexicon.tenetList)
        {
            for (int i = 0; i < c.GetFrequency(); i++)
            {
                initialTenetPile.PlaceOnTop(c);
            }
        }

        //Shuffle the initial pile
        initialTenetPile.Shuffle();

        //TODO: get the player reference
        Player[] players = new Player[1];

        foreach (Player p in players)
        {
            //Present the player with the tenet options
            //Then take the rejected options and put them into the reject pile
            rejectedTenetPile.PlaceOnTop(p.GiveTenetOptions(initialTenetPile.DrawTop(TENET_DRAW_OPTIONS)));
        }
    }
}
