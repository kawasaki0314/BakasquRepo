using UnityEngine;
using System.Collections;

using Unity.VisualScripting;

public class Respwan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*
    [Header("リスポーン時間の設定")]//
    [SerializeField] private float minRespwanTime = 2f;
    [SerializeField] private float maxRespawnTime = 7f;

    [Header("プレイヤーからの出現範囲(半径)")]
    [SerializeField] private float minDistance = 2f;
    [SerializeField] private float maxDistance = 5f;

    private Collider2D col;
    private SpriteRenderer sr;

    private void Start()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(RespawnRoutine(collision.transform));
        }
    }

    private IEnumerator RespawnRoutine(Transform playerTransform)                    //ここがエラーはいてる
    {
        col.enabled = false;
        sr.enabled = false;
    }



    // Update is called once per frame
    void Update()
    {
        
    }*/
}
