using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player1 : Abstract
{
    [SerializeField] private UI ui;


    private void OnGUI()
    {
        if (GUI.Button(new Rect(120, 80, 180, 50), "Player 1"))
        {
            ui.Stats = ("Health: " + Health + "\nDefense: " + Defense);
        }
    }
}