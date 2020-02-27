using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apples;
namespace Apples{
public class MasterManager : MonoBehaviour
{
   public GameObject key;
        public GameObject door;
        public bool unlockDoor = false; //False = locked door
        public Renderer keyColor;

        public virtual void Awake()
        {
            keyColor = GetComponent<Renderer>();
        }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            { //If the player touches the key, it will change the door to unlocked and destroy the key
                unlockDoor = true;
                key.SetActive(false);
                door.SetActive(false);
            }
        }
}
}