using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float m_speed; 
    CharacterController m_characterController;

    void Awake()
    {
        GameController.Instance.Player = gameObject;
        m_characterController = GetComponent<CharacterController>();    
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
       float horizontal = Input.GetAxis("Horizontal");
       float vectical = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * horizontal) + (transform.forward * vectical);
        m_characterController.Move(move * Time.deltaTime * m_speed);
    }
}
   
