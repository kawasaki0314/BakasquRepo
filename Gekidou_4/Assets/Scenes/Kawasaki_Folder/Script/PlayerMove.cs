using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f;
    public float blinkDistance = 5.0f;
    public float blinkDuration = 0.1f;
    private bool isBlinking = false;
    // Update is called once per frame
    void Update()
    {
        Vector2 move = Vector2.zero;

        // エラーを防ぐため
        if (Keyboard.current == null) return;

        // Aを押すと左移動,左を向く
        if (Keyboard.current.aKey.isPressed)
        {
            move.x -= 1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        // Dを押すと右移動,右を向く
        else if (Keyboard.current.dKey.isPressed)
        {
            move.x += 1;
            transform.localScale = new Vector3(1, 1, 1);
        }
        // Wを押すと上移動
        if (Keyboard.current.wKey.isPressed)
        {
            move.y += 1;
        }
        // Sを押すと下移動
        else if (Keyboard.current.sKey.isPressed)
        {
            move.y -= 1;
        }

        transform.position += (Vector3)(move * speed * Time.deltaTime);

        // 右クリックするとブリンク
        // 右クリックを検出
        if(Mouse.current.rightButton.wasPressedThisFrame && move != Vector2.zero && !isBlinking)
        {
            StartCoroutine(Blink(move));
        }

        IEnumerator Blink(Vector2 dir)
        {
            isBlinking = true;

            Vector3 start = transform.position;
            Vector3 end = start + (Vector3)(dir * blinkDistance);

            float time = 0f;
            while (time < blinkDuration)
            {
                transform.position = Vector3.Lerp(start, end, time / blinkDuration);
                time += Time.deltaTime;
                yield return null;
            }

            transform.position = end;

            isBlinking = false;
        }
       
    }
}