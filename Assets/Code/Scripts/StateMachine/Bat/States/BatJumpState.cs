using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BatJumpState : BaseState<BatStates>
{
    public BatJumpState(BatCore contextCore, BatStates States) : base (contextCore, States)
    {
    }

    public override void StateEnter()
    {

    }

    public override void StateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            SwitchState(States.Idle());
    }
    public override void StateFixedUpdate()
    {

    }

    public override void StateExit()
    {
        
    }
}
