using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    private float x;
    private float y;
    private Vector3 rotateValue;
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        Debug.Log(x + ":" + y);
        rotateValue = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}