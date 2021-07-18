using System.Collections;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject Player;

    public static int LivesRemaining = 6;

    void Start()
    {
        Player =
            (GameObject)
            Resources.Load(Application.dataPath + "/Resources/Player");
        Debug.Log(Application.dataPath + "/Resources/Player");
    }

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LivesRemaining--;
            Destroy(collision.gameObject);
            Debug.Log("Life remaining: " + LivesRemaining);
            yield return new WaitForSeconds(2);
            Application.LoadLevel(Application.loadedLevel);
            if (LivesRemaining == 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
