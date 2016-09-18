using UnityEngine;
using System.Collections;

public class BusinessGuy : MonoBehaviour
{
    public float RunSpeed = 0f;
    public float JumpForce = 0f;

    Rigidbody2D body;

	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.left * RunSpeed);

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.AddForce(Vector2.up * JumpForce);
        }
	}
}
