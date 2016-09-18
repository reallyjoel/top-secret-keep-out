using UnityEngine;
using System.Collections;

public class BusinessGuy : MonoBehaviour
{
    public float RunSpeed;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.AddRelativeForce(Vector2.left * RunSpeed - body.velocity);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            body.AddRelativeForce(new Vector2(-500f, 0f));
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.AddRelativeForce(new Vector2(0f, 1000f));
        }
    }

    //IEnumerator Jump()
    //{

    //    while (false)
    //    {

    //    }
    //    yield return null;
    //}
}
