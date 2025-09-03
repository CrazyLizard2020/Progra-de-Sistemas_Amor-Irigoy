using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    StateMachine Machine { get; set; }
    States StateType { get; }
    string StateName { get; }
    void Enter();
    void Exit();
    void UpdateState();
}
