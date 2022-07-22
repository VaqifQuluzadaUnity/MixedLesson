using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;
public class GameManager : MonoBehaviour
{
	private void OnEnable()
	{
		EventManager.Instance.AddListener<OnPlayerDamagedEvent>(OnPlayerDamagedEventHandler);
	}

	private void OnDisable()
	{
		EventManager.Instance.RemoveListener<OnPlayerDamagedEvent>(OnPlayerDamagedEventHandler);

	}


	private void OnPlayerDamagedEventHandler(OnPlayerDamagedEvent eventDetails)
	{
		Debug.Log("Player health: " + eventDetails.playerHealth);
	}
}
