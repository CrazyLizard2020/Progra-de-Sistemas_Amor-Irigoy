using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private AttackComponent attackComponent;

    public AttackComponent AttackComponent => attackComponent;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackComponent.Attack();
        }
    }
}
