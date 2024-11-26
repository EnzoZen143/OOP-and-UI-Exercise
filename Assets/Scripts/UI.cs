using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 500, 710), "");
    }
}
