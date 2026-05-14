using UnityEngine;

public class EnemyChasePhysics : MonoBehaviour
{
    public Transform target;

    public float speed = 5f;

    public float maxSpeed = 10f;


    private Rigidbody rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    //   rd = GetComponent();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //  if (target == nu11) return;

        //プレイヤーへの方向ベクトル(xz平面のみ)
        Vector3 direction = (target.position - transform.position);
        direction.y = 0; //高さは無視(地面を這う敵用)
        direction = direction.normalized;


        //最大速度を制限
       // if(rd.angularVelocity = rb)
    }
}
