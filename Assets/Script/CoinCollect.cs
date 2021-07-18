using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we need to add this library if we use UI
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    //variable for coin counter
    public int coin;

    //will be started once at beginn
    void Start()
    {
    }

    //will be startet, if collider2D went into the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //check, if gameobject has tag Coin
        if (other.tag == "Coin")
        {
            //increment the coin counter variable
            coin = coin + 1;

            //delete coin gameobject from the scene
            Destroy(other.gameObject);
        }
    }
}
