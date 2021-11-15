using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float touchclicked = Input.GetAxis("Fire1");
        if (touchclicked == 1f)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        Vector2 ScreenPotition = Camera.main.WorldToScreenPoint(transform.position);

        if(ScreenPotition.y > Screen.height || ScreenPotition.y < 0)
        {
            Die();
        }

        void Die()
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Menu");
        }

        void Collision2DEnter(Collision2D coll)
        {
            Die();
        }
    }
}
