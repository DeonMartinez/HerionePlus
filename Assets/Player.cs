using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IStates mCurrentState;
    public  float speed = 100f;
    public Rigidbody player;

    void Awake()
    {
        mCurrentState = new StandingState();
        mCurrentState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        mCurrentState.Execute(this);
        if (Input.GetKey("d"))
        {
            player.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            player.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
