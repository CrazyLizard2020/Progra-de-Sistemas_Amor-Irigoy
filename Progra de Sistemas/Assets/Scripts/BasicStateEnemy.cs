using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStateEnemy : MonoBehaviour
{
    private bool detected = false;
    [SerializeField] private string id;

    private States currentState = States.Patrolling;

    private Dictionary<States, IState> stateDict = new Dictionary<States, IState>
    {
        { States.Patrolling, new PatrollingState() },
        { States.Attacking,  new AttackingState() }
    };

    //private PatrollingState patrollingState;
    //private AttackingState attackingState;

    public States CurrentStateType
    {
        get { return currentState; }
        set { currentState = value; }
    }

    public bool Detected => detected;
    public string ID => id;

    public enum States
    {
        Patrolling,
        Attacking
    }

    private void Start()
    {
        stateDict[currentState].Enter();
        //patrollingState.Enter();
    }

    private void Update()
    {
        stateDict[currentState].UpdateState(this);

        //switch (currentStateType)
        //{
        //    case States.Patrolling:
        //        patrollingState.UpdateState(this);
        //        break;

        //    case States.Attacking:
        //        attackingState.UpdateState(this);
        //        break;
        //}
    }

    public void ChangeState(States newState)
    {
        stateDict[currentState].Exit();

        currentState = newState;
        
        stateDict[currentState].Enter();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            detected = true;
        }
        //Debug.Log("hola");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            detected = false;
        }
        //Debug.Log("chau");
    }
}
