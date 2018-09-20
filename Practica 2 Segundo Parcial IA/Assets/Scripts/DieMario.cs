using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMario : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Choque"))
		{
			Destroy(gameObject);
		}
	}
}
