using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;
namespace Apples
{
    public class YellowKey : MasterManager
    {
        public void Start()
        {
            keyColor.material.color = Color.yellow; //Changes the key color to Red
        }

    }
}