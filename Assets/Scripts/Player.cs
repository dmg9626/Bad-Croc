using UnityEngine;
using System.Collections;

public class Player : Actor {

    public Camera camera;

	
	// Update is called once per frame
	void Update () {
        HandleMovement();
        Debug.Log("Velocity: " + GetComponent<Rigidbody2D>().velocity);
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z); 
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("user pressing D");
            
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveSpeed);

            if(GetComponent<Rigidbody2D>().velocity.magnitude >= maxSpeed)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.right * maxSpeed;
            }
        }
    }
}
