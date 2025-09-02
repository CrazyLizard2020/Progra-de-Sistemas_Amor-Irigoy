using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    IState currentState;

    [SerializeField] private List<IState> states = new List<IState>();

    Dictionary<States, IState> statesDict;

    public enum States
    {
        Idle,
        Run,
        Walk
    }

    public void Initialize()
    {
        if (statesDict[States.Idle] != null)
        {
            currentState = statesDict[States.Idle];
            currentState.Enter();
        } else
        {
            Debug.Log("No Idle state");
        }
    }

    public void UpdateState()
    {
        currentState.UpdateState();
    }

    public void ChangeState(IState state)
    {
        currentState.Exit();
        currentState = state;
        currentState.Enter();
    }
}
