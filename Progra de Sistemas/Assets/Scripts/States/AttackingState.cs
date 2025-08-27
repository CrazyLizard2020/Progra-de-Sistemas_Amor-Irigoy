using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingState : IState
{
    public void Enter()
    {
        Debug.Log("Entrando a Attacking");
    }

    public void Exit()
    {
        Debug.Log("Saliendo de Attacking");
    }

    public void UpdateState(BasicStateEnemy character)
    {
        if (character.Detected != true)
        {
            character.ChangeState(BasicStateEnemy.States.Patrolling);
        }
    }

}
