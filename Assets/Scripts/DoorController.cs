using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;
namespace Apples
{
    public class DoorController : MonoBehaviour
    {

        public bool red;
        public bool green;
        public bool yellow;
        public GameObject door;

        void Start()
        {
            red = true;
            green = true;
            yellow = true;
            door.SetActive(true);
        }

        void Update()
        {
            if (red & green & yellow == false)
            {
                door.SetActive(false);
            }
        }
    }
}
