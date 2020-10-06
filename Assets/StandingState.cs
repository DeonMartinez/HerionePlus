using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : IStates
{
    public void Enter(Player player)
    {
        player.mCurrentState = new StandingState();
        Debug.Log("Enter Standing state");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            FlyingState flyingState = new FlyingState();
            flyingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuickState quickState = new QuickState();
            quickState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            FreakOutState freakOutState = new FreakOutState();
            freakOutState.Enter(player);
        }
    }
}
