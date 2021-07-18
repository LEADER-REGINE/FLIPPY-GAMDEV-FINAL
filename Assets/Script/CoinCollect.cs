using System.Collections;
using System.Collections;
using UnityEngine;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy (gameObject);
        }
    }
}
