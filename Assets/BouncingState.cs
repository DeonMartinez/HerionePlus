using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreakOutState : IStates
{
    public float randSize;
    public Rigidbody rb;


    public void Enter(Player player)
    {
        (player.GetComponent("Halo") as Behaviour).enabled = true;

        player.mCurrentState = new FreakOutState();
        Debug.Log("Enter Freak Out state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            (player.GetComponent("Halo") as Behaviour).enabled = false;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }


}
