using UnityEngine;

public class AiHoming : MonoBehaviour
{
    Transform playerTr;//プレイヤーのTransform
    [SerializeField] float speed = 2;  //敵の動くスピード



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //プレイヤーのtransformを取得(プレイヤーのタグをplayerに設定必要)
        playerTr = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        //プレイヤーとの距離が0.1fになったらそれ以上実行しない
        if (Vector2.Distance(transform.position, playerTr.position) < 0.1f)
            return;

        //プレイヤーに向けて進む
        transform.position = Vector2.MoveTowards(
            transform.position,
            new Vector2(playerTr.position.x, playerTr.position.y),
            speed * Time.deltaTime);
    }
    //ここから追加：当たった時の判定処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //衝突した相手のタグが"Player"だった場合
        if (collision.CompareTag("Player"))
        {
            Debug.Log("プレイヤーに当たりました!");

            //例 : プレイヤーにダメージを与える処理をここに書く
            //collision.GetComponent<PlayerHealth>.TakeDamage(1);

            //例　: 当たったら敵自身を消滅させる場合
            Destroy(gameObject);
        }
    }
}