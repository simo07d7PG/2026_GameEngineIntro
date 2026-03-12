using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public float moveSpeed;
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("0");
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1 , 1, 1);
            Debug.Log("1");
        }
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * moveSpeed);
    }
}
