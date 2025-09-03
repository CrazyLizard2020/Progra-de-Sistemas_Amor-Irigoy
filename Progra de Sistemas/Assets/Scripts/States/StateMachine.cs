using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States
{
    Idle,
    Run,
    Walk
}

public class StateMachine : MonoBehaviour
{
    IState currentState;
    [SerializeField] private string currentStateName;
    PlayerController player;

    Dictionary<States, IState> statesDict = new Dictionary<States, IState>();

    public PlayerController Player => player;

    public void Initialize(PlayerController player)
    {
        this.player = player;

        IState[] statesInChildren = GetComponentsInChildren<IState>();

        foreach (IState state in statesInChildren) 
        {
            state.Machine = this;
            statesDict.Add(state.StateType, state);
        }


        if (statesDict[States.Idle] != null)
        {
            currentState = statesDict[States.Idle];
            currentState.Enter();
        }
        else
        {
            Debug.Log("No Idle state");
        }
    }

    public void UpdateState()
    {
        currentState.UpdateState();
        currentStateName = currentState.StateName;
    }

    public void ChangeState(States newState)
    {
        currentState.Exit();
        currentState = statesDict[newState];
        currentState.Enter();
    }
}
