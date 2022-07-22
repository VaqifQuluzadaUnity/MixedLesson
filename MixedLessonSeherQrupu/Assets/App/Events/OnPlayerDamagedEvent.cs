using System.Collections;
using System.Collections.Generic;
using DynamicBox.EventManagement;
public class OnPlayerDamagedEvent:GameEvent
{
    public int playerHealth;

  public OnPlayerDamagedEvent(int PlayerHealth)
	{
		playerHealth = PlayerHealth;
	}
}
