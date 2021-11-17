using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZoneLevel3 : MonoBehaviour
{
    Material mat;
    public bool loadCompletionScreen;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Object collides with another object
    private void OnCollisionEnter(Collision other)
    {
        // Ignore non-player collisions
        if (other.gameObject.tag != "Player") return;

        mat.color = new Color(0, 1.0f, 0, 0.5f);

        if (loadCompletionScreen) SceneManager.LoadSceneAsync("CompletionScreen");
    }
}
