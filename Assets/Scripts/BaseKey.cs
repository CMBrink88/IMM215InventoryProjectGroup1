using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;

namespace Apples
{
    public class BaseKey : MonoBehaviour
    {
        public GameObject key;
        public GameObject door;
        public bool unlockDoor = false; //False = locked door
        public Renderer keyColor;

        public virtual void Start()
        {
            keyColor = GetComponent<Renderer>();
            keyColor.material.color = Color.yellow; //Changes the color of the key to Yellow
        }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            { //If the player touches the key, it will change the door to unlocked and destroy the key
                unlockDoor = true;
                key.SetActive(false);

            }
        }

    }
}