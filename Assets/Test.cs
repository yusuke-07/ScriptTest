using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;  // 体力
    private int power = 25; // 攻撃力
    public int mp = 53; //魔法力

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

    // 魔法攻撃用の関数（発展課題）
    public void Magic()
    {
        // MPが5以上ある場合に魔法攻撃をする
        if (this.mp >= 5)
        {
            // MPを5消費する
            this.mp -= 5;
            // 残りMPを表示する
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            // 残りMPが足りない場合に表示する
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

}

public class Test : MonoBehaviour
{
    void Basic()
    {
        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int a = 0; a < array.Length; a++)
        {
            // 配列の要素が0以上の場合
            if (array[a] >= 0)
            {
                // 配列の要素を表示する
                Debug.Log(array[a]);
            }
        }

        // 配列の要素数のぶんだけ処理を繰り返す(逆順)
        for (int i = 4; i >= 0; i--)
        {
            // 配列の要素が0以上の場合
            if (array[i] >= 0)
            {
                // 配列の要素を表示する
                Debug.Log(array[i]);
            }
        }
    }


    void Start()
    {
        // 「課題：配列を宣言して出力しよう」の内容をBasic関数として呼び出す
        Basic();

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法攻撃用の関数を11回呼び出す（発展課題）
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}