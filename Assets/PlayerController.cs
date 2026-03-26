using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public float moveSpeed = 10.0f;
    public float jumpModifier = 10.0f;
    private Rigidbody2D rb;
    private Animator ani;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        if(ani == null) { Debug.Log("fail to get component"); }
        ani.SetBool("move", false);
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    public void OnJump(InputValue value)
    {
        if(value.isPressed)
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpModifier);
    }
    void Update()
    {
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("0");
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            Debug.Log("1");
        }
        if (moveInput.magnitude > 0) { ani.SetBool("move", true); }
        else {
            ani.SetBool("move", false);
        }

        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("PlayScene_" + collision.name);
    }
}
