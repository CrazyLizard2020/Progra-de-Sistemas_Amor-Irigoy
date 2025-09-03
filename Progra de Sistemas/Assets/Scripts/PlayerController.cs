using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private AttackComponent attackComponent;

    [SerializeField] private StateMachine machine;

    private float horizontal;
    private float vertical;

    public AttackComponent AttackComponent => attackComponent;
    public float Horizontal => horizontal;
    public float Vertical => vertical;

    private void Start()
    {
        machine.Initialize(this);
    }

    void Update()
    {
        machine.UpdateState();

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackComponent.Attack();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IWeapon weapon = other.gameObject.GetComponent<IWeapon>();
        
        if (weapon == null)
        {
            return;
        }

        attackComponent.ChangeWeapon(weapon);
    }

    public void Move()
    {
        transform.Translate(new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime));
    }
}
