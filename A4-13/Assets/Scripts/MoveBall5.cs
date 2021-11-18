using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall5 : MonoBehaviour
{

    public float movementSpeed = 1f;
    Vector3 point1;
    Vector3 point2;

    // Start is called before the first frame update
    void Start()
    {
        point1 = new Vector3(158, 1.5f, 245);
        point2 = new Vector3(92, 1.5f, 245);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time*movementSpeed, 1);
        transform.position = Vector3.Lerp(point1, point2, time);
    }
}
