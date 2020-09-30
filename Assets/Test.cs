using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;    //体力
    private int power = 25;  //攻撃力
    private int mp = 53;     //魔法攻撃力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "ダメージを受けた");

        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃の関数
    public void Magic()
    {
        //残りmpを減らす
        this.mp -= 5;

        if(this.mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = {10, 30, 44, 67, 21, 43, 23, 78};

        for(int i = 0; i < points.Length; i++)
        {
            Debug.Log(points [i]);
        }

        for(int i = points.Length - 1; 0 <= i; i--)
        {
            Debug.Log(points [i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();

        //防御用の関数を呼び出す
        lastboss.Defence(3);

        //魔法攻撃の関数を呼び出す
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
