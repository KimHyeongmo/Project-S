using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    [Header("Entity Information")]
    [SerializeField]
    protected bool attacked;
    [SerializeField]
    protected int hp;
    [SerializeField]
    protected int damage;

    public bool Attacked
    {
        get { return attacked; }
        set { attacked = value; }
    }

    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    [Header("Current Physics")] //기본 값 조정이 아닌 순간 물리 값임.
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float jump;

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public float Jump
    {
        get { return jump; }
        set { jump = value; }
    }

    //기본 값 도 만들어서 이 값을 통해 외부로 부터 영향을 받을 수 있도록 한다.
    //기본 값은 가속도, 최대 속도, 점프 속도 등이 포함될 것
    [Header("Before Physics")] //기본 값 조정이 아닌 순간 물리 값임.
    [SerializeField]
    [Range(0, 10)]
    protected float before_speed;
    [SerializeField]
    [Range(0,100)]
    protected float max_speed;
    [SerializeField]
    [Range(0, 100)]
    protected float before_jump;
    [SerializeField]
    [Range(-10, 0)]
    protected float down_accel;


}
