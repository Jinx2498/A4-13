using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 15 * Time.deltaTime, 45 * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        other.GetComponent<PlayerStats>().points++;
    }
}
