using UnityEngine;

public class heelitem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if ((collision.gameObject.tag == "Player"))
        {
            Destroy(this.gameObject,1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
