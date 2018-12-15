using UnityEngine;

public class AutoMan : MonoBehaviour
{

	public AudioSource AudioSource;
	void Start ()
	{
		AudioSource = GetComponent<AudioSource>();
	}
	
}
