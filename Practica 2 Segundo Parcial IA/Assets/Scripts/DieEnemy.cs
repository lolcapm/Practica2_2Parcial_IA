using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Pisada"))
		{
			Destroy(gameObject);
		}
	}
}

				
