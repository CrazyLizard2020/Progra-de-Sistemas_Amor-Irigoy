using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingState : IState
{
    PlayerController player;
    private StateMachine machine;
    private States stateType = States.Idle;
    string stateName = "Idle";

    public StateMachine Machine
    {
        get { return machine; }
        set { machine = value; }
    }
    public States StateType => stateType;
    public string StateName => stateName;

    public void Enter()
    {
        Debug.Log("Entrando a Patrolling");
    }

    public void Exit()
    {
        Debug.Log("Saliendo de Patrolling");
    }

    public void UpdateState(BasicStateEnemy character)
    {
        if (character.Detected == true)
        {
            character.ChangeState(BasicStateEnemy.States.Attacking);
        }
    }

    public void UpdateState() { }
}
