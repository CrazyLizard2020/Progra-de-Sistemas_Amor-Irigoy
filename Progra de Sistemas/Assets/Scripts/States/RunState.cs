using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RunState : MonoBehaviour, IState
{
    PlayerController player;
    private StateMachine machine;
    private States stateType = States.Run;
    string stateName = "Run";

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

    }

    public void Exit()
    {
        Debug.Log("Me despido soy " + stateName);
    }
}
