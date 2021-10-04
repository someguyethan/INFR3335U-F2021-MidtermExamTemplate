using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCoins : MonoBehaviour
{
    int coinCounter = 0;

    void Update()
    {
        if (coinCounter == 10)
            SceneManager.LoadScene("End");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coinCounter++;
        }
    }
}
