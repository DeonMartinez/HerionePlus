using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickState : IStates
{

    public float lightMass = 1f;
    public float normalMass = 10f;
    public void Enter(Player player)
    {
        player.mCurrentState = new QuickState();

        player.GetComponent<Rigidbody>().mass = lightMass;
        Debug.Log("Enter Quick state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.GetComponent<Rigidbody>().mass = normalMass;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            Debug.Log("Enter didldo Bagins");
            player.GetComponent<Rigidbody>().mass = normalMass;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
