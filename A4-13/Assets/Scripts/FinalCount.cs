using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCount : MonoBehaviour
{
    public int coinTotal;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject statsObj = GameObject.Find("PlayerStats");
        coinTotal = statsObj.GetComponent<PlayerStats>().points;
        TMPro.TextMeshPro tm = GameObject.Find("Text/Coins").GetComponent<TMPro.TextMeshPro>();
        tm.text = "Coins Collected: " + coinTotal.ToString();
        Destroy(statsObj);
    }

    /*
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins Collected: " + coinTotal);
    }
    // */
}
