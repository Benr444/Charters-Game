using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private Board board;

    public Player()
    {
        board = new Board();
    }

    //Return rejected cards
    public TenetCard[] GiveTenetOptions(TenetCard[] givenTenets)
    {
        //Just pick the first three for now
        for (int i = 0; i < Board.MAX_TENETS; i++)
        {
            board.GiveTenet(givenTenets[i]);
        }

        //Collect the rejected tenets
        TenetCard[] rejectedTenets = new TenetCard[givenTenets.Length - Board.MAX_TENETS];

        //More collecting
        for (int i = 0; i < rejectedTenets.Length; i++)
        {
            rejectedTenets[i] = givenTenets[i + Board.MAX_TENETS];
        }

        //Reveal the picked tenets
        board.RevealTenets();

        //Return the rejected tenets
        return rejectedTenets;
    }
}
