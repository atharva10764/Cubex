
using UnityEngine;

public class collsion : MonoBehaviour {

    public player movement;
	void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }
}
