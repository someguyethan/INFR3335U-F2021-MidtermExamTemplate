using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    Transform coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.Rotate(new Vector3(0f, 0f, Time.deltaTime * 100f));
    }
}
