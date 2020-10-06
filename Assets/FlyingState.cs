using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingState : IStates
{
    public void Enter(Player player)
    {
        player.mCurrentState = new FlyingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 1f, 0);
        player.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log("Enter Flying state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<Rigidbody>().useGravity = true;
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            player.GetComponent<Rigidbody>().useGravity = true;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }


}
