using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float side=400;
    public float front = 1000;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, front*Time.deltaTime);
        if (Input.GetKey("d")|| Input.GetKey("right"))
        {
            rb.AddForce(side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")|| Input.GetKey("left"))
        {
            rb.AddForce(-1 * side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1)
        {
            FindAnyObjectByType<GameManage>().EndGame();
        }
    }
}
