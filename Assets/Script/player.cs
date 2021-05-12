
using UnityEngine;

public class player : MonoBehaviour {

    public Rigidbody rb;

    public float ff = 2000f;
    public float sf = 500f;
	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, ff * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sf * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sf * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().Endgame();
        }



    }
}
