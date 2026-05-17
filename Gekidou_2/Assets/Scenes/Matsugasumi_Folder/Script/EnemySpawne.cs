using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //ここ(関数の外)に書くことで、スクリプト内のどこからでも使えるようになります!
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnInterVal = 1.0f; //1秒ごとに設定

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // 定期生成を行うコルーチンを開始
        StartCoroutine(SpawnRoutine());
    }

    //2. 足りなかったコルーチン本体です
    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            //1秒待つ
            yield return new WaitForSeconds(spawnInterVal);

            //for文をつあって、1秒経つたびに5回　SpawnEnemy を実行する
            for (int i = 0; i < 5; i++)
            {
                SpawnEnemy();
            }
        }
    }
    //3. 足りなかった「実際に敵を生み出す処理」です
    private void SpawnEnemy()
    {
        if (enemyPrefab == null) return;　//これなら正常に見つかる!

        //半径5マスの円の中のランダムな位置を計算
        Vector2 randomOffset = Random.insideUnitCircle * 5f;
        Vector2 spawnPosition = transform.position + new Vector3(randomOffset.x, randomOffset.y, 0);

        //計算したランダム位置に複製
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
 }