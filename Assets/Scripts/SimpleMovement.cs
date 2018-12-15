using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
	public float Speed = 12f;
	public Vector3 MovementDirection = Vector3.right;

	void Update ()
	{
		transform.position += MovementDirection * Speed * Time.deltaTime;
	}
}
