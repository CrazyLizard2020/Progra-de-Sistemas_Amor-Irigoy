using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : MonoBehaviour, IState
{
    PlayerController player;
    private StateMachine machine;
    private States stateType = States.Walk;
    string stateName = "Walk";

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
        if (player.Horizontal == 0 && player.Vertical == 0)
        {
            machine.ChangeState(States.Idle);
            return;
        }
        
        player.Move();
    }

    public void Exit()
    {
        Debug.Log("Me despido soy " + stateName);
    }
}
