using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2 : MonoBehaviour
{
    public Texture2D buttonimage;
    public Vector2 position = new Vector2(500, 50);
    public Vector2 size = new Vector2(2000, 2000);
    public string labelText = "Player Stat Here";

    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 600, 620), "Choose your Survivor");

        if (GUI.Button(new Rect(100, 100, 150, 100), "Enzo"))
            
            print("Player 1");
    }

}