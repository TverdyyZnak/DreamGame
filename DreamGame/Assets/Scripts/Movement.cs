using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private InputSystem_Actions inputPlayerMove;
    private Transform objectTransform;
    private Animator animator;
    [SerializeField]   private float mSpeed = 5f;
    private void Awake() 
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        objectTransform = this.GetComponent<Transform>();
        inputPlayerMove = new InputSystem_Actions();
        inputPlayerMove.Enable();
    }

    private Vector2 GetVector2Move()
    {
        Vector2 moveVector2 = inputPlayerMove.Player.Move.ReadValue<Vector2>();
        return moveVector2;
    }



    private void FixedUpdate() 
    {
        Vector2 inputVector = GetVector2Move();

        if(inputVector != new Vector2(0, 0))
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }

        
        if (Mouse.current.position.ReadValue().x < Camera.main.WorldToScreenPoint(transform.position).x)
        {

            objectTransform.localScale = new Vector3(-1, 1, 1);
        }
        else if(Mouse.current.position.ReadValue().x > Camera.main.WorldToScreenPoint(transform.position).x)
        {
            objectTransform.localScale = new Vector3(1, 1, 1);
        }
        rb.MovePosition(rb.position + GetVector2Move().normalized * (mSpeed * Time.fixedDeltaTime));
        

    }
    
}
