using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class PlayerCollisionDetector : MonoBehaviour
{
	[SerializeField] private int playerHealth=100;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("DamageArea"))
		{
			playerHealth -= 10;

			EventManager.Instance.Raise(new OnPlayerDamagedEvent(playerHealth));
		}
	}
}
