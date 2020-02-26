using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;

namespace Apples
{
    public class BaseKey : MasterManager
    {
        public void Start()
        {
            keyColor.material.color = Color.yellow; //Changes the key color to Green
        }
    }
}