using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
    // Start is called before the first frame update
    void Start()
    {
        

    }
    // Marked FixedUpdate because it alters physiscs
    void FixedUpdate()
    {
        // add force of 2000 on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if ( Input.GetKey("a") ) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
