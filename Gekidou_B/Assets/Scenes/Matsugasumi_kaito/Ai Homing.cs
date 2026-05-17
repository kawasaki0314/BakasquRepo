using System.Runtime.InteropServices.WindowsRuntime;
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
}
