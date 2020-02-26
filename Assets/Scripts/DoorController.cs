using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;
namespace Apples
{
    public class DoorController : MonoBehaviour
    {

        bool red;
        bool green;
        bool yellow;
        public GameObject door;
        void Start()
        {
            red = true;
            green = true;
            yellow = true;
        }

        void Update()
        {
            if (red & green & yellow == true)
            {
                door.SetActive(false);
            }
        }

        void OnCollisonEnter()
        {
            //if 
        }
    }
}
