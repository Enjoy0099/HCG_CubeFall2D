using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Platform
{
    is_Platform,
    is_Breakable, 
    is_Spike, 
    moving_Platform_Left, 
    moving_Platform_Right
}

public class PlatformScript : MonoBehaviour
{

    public float move_Speed = 2f;
    public float bound_Y = 6f;

    public Platform platform;

    private Animator anim;

    private void Awake()
    {
        if(platform == Platform.is_Breakable)
        {
            anim = GetComponent<Animator>(); 
        }
    }


    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if(temp.y >= bound_Y)
        {
            gameObject.SetActive(false);
        }
    }


}
