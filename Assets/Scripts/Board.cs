using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    public static readonly uint MAX_TENETS = 3;

    private TenetCard[] selectedTenets;

	public Board()
    {
        selectedTenets = new TenetCard[MAX_TENETS];
    }

    //Give the board a tenet during the draft. The tenet is face-down initially
    public void GiveTenet(TenetCard tenet)
    {
        //Turn the tenet face-down
        tenet.SetFaceUp(false);

        //Push it onto your board
        for (int i = 0; i < selectedTenets.Length; i++)
        {
            if (selectedTenets[i] == null)
            {
                selectedTenets[i] = tenet;
            }
        }

    }

    public void RevealTenets()
    {
        foreach (TenetCard t in selectedTenets)
        {
            t.SetFaceUp(true);
        }
    }
}
