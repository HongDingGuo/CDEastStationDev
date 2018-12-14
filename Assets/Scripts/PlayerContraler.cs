using UnityEngine;
using System.Collections;
using System.Linq;

public class PlayerContraler : MonoBehaviour
{

    private float m_speed = 10;
    public CharacterController m_character;
    void Start()
    {
        m_character.GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D 左右
        float vertical = Input.GetAxis("Vertical"); //W S 上 下
        m_character.SimpleMove(transform.forward * vertical * m_speed);
        m_character.SimpleMove(transform.right * horizontal * m_speed);
    }
    
}
