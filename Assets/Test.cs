using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;




public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        {
            // 変数を初期化する
            int d = 3;
            int e = 4;
            // 変数aと変数bの合計値を変数cに代入する
            int f = d + e;
            // 変数cを表示する　
            Debug.Log(f);
        }

        // moneyを100で初期化する
        int money = 100;
        if (money <= 50)
        {
            // moneyが50以下だった場合の処理
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            // moneyが200以上だった場合の処理
            Debug.Log("武器を買う");
        }
        else
        {
            // それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }

        int val;
        int num = 1;
        if (num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        Debug.Log(val);


        // 変数aを3で初期化する
        int a = 3;
        if (a == 3)
        {
            // 変数aが3の場合、変数bを5で初期化する
            int b = 5;
            // 変数bの値を表示する
            Debug.Log(b);
        }

        // sumを0で初期化する
        int sum = 0;
        // 10回処理を繰り返す
        for (int i = 1; i <= 10; i++)
        {
            // iの値をsumに足す
            sum += i;
        }
        // sumの値を表示する
        Debug.Log(sum);

        // 配列を初期化する
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
           // 配列の要素が50以上の場合
           if (points[i] >= 50)
           {
                // 配列の要素を表示する
                Debug.Log(points[i]);
           }
        }

            //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
            int[] array = { 63, 59, 43, 22, 100 };


            //for文を使い、配列の各要素の値を順番に表示してください
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(array[i]);
            }

            //for文を使い、配列の各要素の値を逆順に表示してください
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }

    }
    // Update is called once per frame
    void Update()
    {

    }

}
public class kansuu : MonoBehaviour
{
    // 「Hello, UnityChan」と表示する関数
    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Hello関数を呼び出す
        Hello();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Boss
{
    private int hp = 50;   // 体力
    private int power = 15; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test2: MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
