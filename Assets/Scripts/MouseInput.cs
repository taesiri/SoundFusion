using UnityEngine;
using UnityEngine.AI;

public class MouseInput : MonoBehaviour
{
	public GameObject PlayerObject;
	private Vector3 _offset;
	public float MouseWheelSpeed = -2f;
	public NavMeshAgent Agent;

	void Start()
	{
		_offset = transform.position - PlayerObject.transform.position;
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{
					Agent.SetDestination(hit.point);
				}
			}
		}

		var changeAmount = Input.GetAxis("Mouse ScrollWheel") * MouseWheelSpeed;
		_offset += _offset.normalized * changeAmount;
	}

	void LateUpdate()
	{
		transform.position = PlayerObject.transform.position + _offset;
	}
}