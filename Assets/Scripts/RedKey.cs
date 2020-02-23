//IMM215 Inventory Assignment Group 1
//By Chris Brinkley, Micheal Douglas and Owen Engle
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKey : BaseKey
{
    override public void Start()
    {
        keyColor = GetComponent<Renderer>();
        keyColor.material.color = Color.red; //Changes the key color to Red
    }

}
