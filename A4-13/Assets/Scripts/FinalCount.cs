using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCount : MonoBehaviour
{
    /*
    public Text text;
    public int coinTotal;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = GetComponent<PlayerStats>().points.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        text.text = coinTotal.ToString();
    }*/

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins Collected: " + GetComponent<PlayerStats>().points);
    }
}
