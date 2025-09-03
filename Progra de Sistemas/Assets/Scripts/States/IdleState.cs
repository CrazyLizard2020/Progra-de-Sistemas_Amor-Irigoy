using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : MonoBehaviour, IState
{
    private PlayerController player;
    private StateMachine machine;
    private States stateType = States.Idle;
    private string stateName = "Idle";

    public StateMachine Machine
    {
        get { return machine; }
        set { machine = value; }
    }
    public States StateType => stateType;
    public string StateName => stateName;
    

    private void Awake()
    {
        player = machine.Player;
    }

    public void Enter()
    {
        Debug.Log("Hola soy " + stateName);
    }

    public void UpdateState()
    {
        if(player.Horizontal != 0  || player.Vertical != 0)
        {
            machine.ChangeState(States.Walk);
        }
    }

    public void Exit()
    {
        Debug.Log("Me despido soy " + stateName);
    }
}
