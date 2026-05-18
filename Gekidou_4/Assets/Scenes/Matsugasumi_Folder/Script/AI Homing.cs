using UnityEngine;
using Unity.VisualScripting;

public class AIHoming : MonoBehaviour
{
    /*
    Transform playerTr;//プレイヤーのTransform

    [SerializeField] float speed = 2f;  //敵の動くスピード

    //=== 追加===
    [Header("Enemy Status")]
    [SerializeField] int maxHP = 3; //敵の最大HP
    [SerializeField] int attackPower = 1;　//敵の攻撃力

    int currentHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //プレイヤーのtransformを取得(プレイヤーのタグをplayerに設定必要)
        playerTr = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerObj != null)
        {
            playerTr = playerObj.transform;
        }
        else
        {
            Debug.LogError("タグ'player'が見つかりません。インスペクターで設定を確認してください。");
        }
        //HPの初期化
        currentHP = maxHP;
    }

    // Update is called once per frame
    private void Update()
    {
        //プレイヤーが見つかっていない、または距離が0.1f未満なら処理しない
        if (playerTr == null ||Vector2.Distance(transform.position, playerTr.position) < 0.1f)
            return;

        //プレイヤーに向けて進む
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerTr.position,//Vector3は自動的にVector2として計算されます
            speed * Time.deltaTime);

    }

   
    //ダメージを受ける関数
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        //HPが0以下なら死亡
        if (currentHP <= 0)
        {
            Die();
        }
    }

    //死亡処理
    void Die()
    {
        Debug.Log("敵を倒した!");

        Destroy(gameObject);
    }

    //プレイヤーに当たった時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("プレイヤーに当たりました!");

            //プレイヤー側のコンポーネントを取得
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            //コンポーネントがちゃんと取得できていればダメージを与える
            if (playerHealth  != null)
            {
                playerHealth.TakeDamage(attackPower);
            }

            //敵を消す
            Destroy(gameObject);
        }
    }
    */
}