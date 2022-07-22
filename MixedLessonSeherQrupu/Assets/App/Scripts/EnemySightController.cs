using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySightController : MonoBehaviour
{
  [SerializeField] private float visualDistance;

  [SerializeField] private float noiseDetectionDistance;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere(transform.position, visualDistance);

		Gizmos.DrawWireCube(transform.position, new Vector3(1,1,1)*noiseDetectionDistance);	
	}
}
