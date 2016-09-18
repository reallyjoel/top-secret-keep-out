using UnityEngine;
using System.Collections;

public class mountain_scroll_2 : MonoBehaviour
{

	float spawn_pos;

	// Use this for initialization
	void Start()
	{
		spawn_pos = -18.57f;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(.1f,0) * Time.deltaTime;
		if (transform.position.x >= 19)
		{
			transform.position = new Vector3(spawn_pos, transform.position.y);	
		}
	}
}