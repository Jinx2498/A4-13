using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    // Object collides with another object
    private void OnTriggerEnter(Collider other)
    {
        // Ignore non-player collisions
        if (other.gameObject.tag != "Player") return;

        // Reset player position by clearing coins & reloading scene
        GameObject.Find("PlayerStats").GetComponent<PlayerStats>().points = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
