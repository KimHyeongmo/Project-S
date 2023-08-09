using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    Rigidbody Player_Rigidbody;

    enum KeyAction { Right, Left, Jump, Attack};
    Dictionary<KeyAction,KeyCode> keys;

    // Start is called before the first frame update
    void Start()
    {

        Player_Rigidbody = GetComponent<Rigidbody>();

        KeySetting();

    }

    private void KeySetting()
    {
        keys = new Dictionary<KeyAction, KeyCode>();
        keys.Add(KeyAction.Right, KeyCode.D);
        keys.Add(KeyAction.Left, KeyCode.A);
        keys.Add(KeyAction.Jump, KeyCode.Space);
        keys.Add(KeyAction.Attack, KeyCode.K);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Moving();
        Debug.Log(Player_Rigidbody.velocity);
    }

    private void Moving()
    {
        speed = Player_Rigidbody.velocity.x;
        jump = Player_Rigidbody.velocity.y;


        if(Input.GetKey(keys[KeyAction.Right]))
        {
            speed += before_speed;
        }
        if(Input.GetKey(keys[KeyAction.Left]))
        {
            speed -= before_speed;
        }

        if(Input.GetKeyDown(keys[KeyAction.Jump]))
        {
            if (Mathf.Abs(jump) < 0.1f)
            {
                jump += before_jump;
            }
        }

        if(Input.GetKeyDown(keys[KeyAction.Attack]))
        {
            Debug.Log(damage);
        }

        if (Mathf.Abs(speed) >= max_speed)
        {
            speed = speed < 0 ? -1*max_speed : max_speed;
        }

        if (jump >= -0.125f && Mathf.Abs(jump) <= -0.0625f)
            jump = down_accel;

        Player_Rigidbody.velocity = new Vector3(speed, jump, 0);
            
    }
    
}
