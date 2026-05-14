using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class EnemyChasePhysics : MonoBehaviour
{
    public Transform target;

    public float speed = 5f;

    public float maxSpeed = 10f;


    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //  if (target == nu11) return;

        //プレイヤーへの方向ベクトル(xz平面のみ)
        Vector3 direction = (target.position - transform.position);
        direction.y = 0; //高さは無視(地面を這う敵用)
        direction = direction.normalized;


        //力を加えて追いかける
        rb.AddForce(direction * speed);


        //最大速度を制限
        //if(rb.velocity.magnitude > maxSpeed)
        {
          //  rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        
    }
}
