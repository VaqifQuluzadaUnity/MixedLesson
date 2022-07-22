using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DynamicBox.EventManagement;
public class UIManager : MonoBehaviour
{
  [SerializeField] private Image healthbarImage;

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
		healthbarImage.fillAmount = eventDetails.playerHealth / 100f;
	}



}
