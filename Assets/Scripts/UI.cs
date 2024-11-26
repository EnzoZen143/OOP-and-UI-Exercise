using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GUIStyle Style;
    public Vector2 position;
    public Vector2 size;

    public string Stats = "Health: \nDefense:";

    private void OnGUI()
    {
        GUI.Box(new Rect(position, size), "");

        GUI.Box(new Rect(100, 100, 100, 100), "");

        GUI.Box(new Rect(899, 166, 595, 418), "");

        GUI.Label(new Rect(158, 136, 181, 86), "Characters");

        GUI.Box(new Rect(899, 166, 595, 418), "");

        GUI.Label(new Rect(899, 166, 595, 418), Stats, Style);
    }
}
