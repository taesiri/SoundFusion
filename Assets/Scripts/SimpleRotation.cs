using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
	public float RotationSpeed = 0.2f;

	void Update()
	{
		transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeed);
	}
}
