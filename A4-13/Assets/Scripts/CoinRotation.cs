using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 15 * Time.deltaTime, 45 * Time.deltaTime, Space.World);
    }

    public void OnTriggerEnter(Collider other)
    {
        // ignore non-player collisions
        if (other.gameObject.tag != "Player") return;

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        other.GetComponent<PlayerStats>().points++;

        // hide coin & destroy when sound is done
        GetComponent<Renderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        Destroy(gameObject, audio.clip.length);
    }
}
