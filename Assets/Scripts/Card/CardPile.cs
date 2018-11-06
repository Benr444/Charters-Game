using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to represent piles of cards like decks, discard piles, etc
//Supposed to follow a physical analog very closely
//TODO: consider make this implement ICollection
public sealed class CardPile<T> where T : CharterCard
{
    //The last index is the top of the pile. 0 is the bottom
    private List<T> pile;

    public CardPile()
    {
        pile = new List<T>();
    }

    public int Count()
    {
        return pile.Count;
    }

    public void PlaceOnTop(T item)
    {
        pile.Add(item);
    }

    //Take the passed pile and put it on top of this one
    public void PlaceOnTop(CardPile<T> otherPile)
    {
        for (int i = 0; i < otherPile.Count(); i++)
        {
            this.PlaceOnTop(otherPile.DrawBottom());
        }
    }

    public void PlaceOnTop(T[] otherPile)
    {
        for (int i = 0; i < otherPile.Length; i++)
        {
            this.PlaceOnTop(otherPile[i]);
        }
    }

    public void PlaceOnBottom(T item)
    {
        pile.Insert(0, item);
    }

    public T DrawItemAt(int index)
    {
        T theItem = pile[index];
        pile.RemoveAt(index);
        return theItem;
    }

    public T DrawTop()
    {
        return DrawItemAt(pile.Count - 1);
    }

    public T DrawBottom()
    {
        return DrawItemAt(0);
    }

    public T[] DrawTop(uint numberOfItems)
    {
        T[] items = new T[numberOfItems];
        for (int i = 0; i < numberOfItems; i++)
        {
            items[i] = DrawTop();
        }
        return items;
    }

    //Randomize the order
    public void Shuffle()
    {

    }
}
