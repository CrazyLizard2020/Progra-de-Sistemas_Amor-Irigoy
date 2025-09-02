using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private AttackComponent attackComponent;

    [SerializeField] private StateMachine machine;

    public AttackComponent AttackComponent => attackComponent;

    private void Start()
    {
        machine.Initialize();
    }

    void Update()
    {
        machine.UpdateState();

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime));

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
}
