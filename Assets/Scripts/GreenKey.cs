using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : BaseKey
{
    override public void Start(){
        keyColor = GetComponent<Renderer>();
        keyColor.material.color = Color.green; //Changes the key color to Green
    }
}
