using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    bool winMessage;
    public Rect winPopup = new Rect(20, 20, 120, 50);
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            winMessage = true;
        }
    }
    void OnGUI()
    {
        if (winMessage == true)
        {
            winPopup = GUI.Window(0, winPopup, DrawWindow, "You Win!");
        }
    }
    void DrawWindow(int windowID)
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "OK"))
        {
            winMessage = false;
        }
    }
}