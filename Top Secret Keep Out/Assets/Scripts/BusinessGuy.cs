using UnityEngine;
using System.Collections;

public class BusinessGuy : MonoBehaviour
{
    public Vector2 Direction;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //body.velocity = Direction;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }

}
