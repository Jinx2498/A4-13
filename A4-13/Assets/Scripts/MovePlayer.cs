using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rb;        // Player
    public float force = 50f;   // Player Movement
    public int jumpCount = 2;   // Jump Counter
    // private Vector3 MousePositionViewport = Vector3.zero;
    // private Quaternion DesiredRotation = new Quaternion();
    // private float RotationSpeed = 15;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //First jump
            if (jumpCount == 2)
            {
                rb.velocity = new Vector3(rb.velocity.x, 5.2f, rb.velocity.z);
                --jumpCount;
            }
            else
            {
                //Second Jump
                if (jumpCount == 1)
                {
                    rb.velocity = new Vector3(rb.velocity.x, 5.2f, rb.velocity.z);
                    --jumpCount;
                    //Begins jump cool down to avoid more than 2 jumps
                    StartCoroutine(Wait());
                }
            }
        }
        //Jump cool down
        IEnumerator Wait()
        {
            //Cool down period
            yield return new WaitForSeconds(1.5f);
            jumpCount = 2;
        }

        // Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.z, 10);
        // Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        // lookPos = lookPos - transform.position;
        // float angle = Mathf.Atan2(lookPos.z, lookPos.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    void FixedUpdate()
    {
        //Forward
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        //Left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Backward
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }
        //Right
        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        
    }
}