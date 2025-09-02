using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingState : IState
{
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
