using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Collider2D col = Physics2D.OverlapCircle(transform.position, 0.2f, LayerMask.GetMask("Ground"));
			bool isGround = col != null;
		}
	}
}
