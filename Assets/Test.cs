using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;     //体力
    private int power = 25;　 //攻撃力

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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
