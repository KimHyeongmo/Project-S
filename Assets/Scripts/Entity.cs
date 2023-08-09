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

    [Header("Current Physics")] //�⺻ �� ������ �ƴ� ���� ���� ����.
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

    //�⺻ �� �� ���� �� ���� ���� �ܺη� ���� ������ ���� �� �ֵ��� �Ѵ�.
    //�⺻ ���� ���ӵ�, �ִ� �ӵ�, ���� �ӵ� ���� ���Ե� ��
    [Header("Before Physics")] //�⺻ �� ������ �ƴ� ���� ���� ����.
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
