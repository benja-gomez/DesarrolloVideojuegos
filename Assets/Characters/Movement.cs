using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Animator m_animator;

    private Rigidbody2D m_body2d;

    private Sensor_Bandit m_groundSensor;

    private bool m_grounded = false;

    private bool m_combatIdle = false;

    private bool m_isDead = false;

    private float horizontal;

    private float speed = 8f;

    private float jumpingPower = 20f;

    private bool isFacingRight = true;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private LayerMask groundLayer;

    // Use this for initialization
    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        // m_groundSensor =
        //     transform.Find("GroundSensor").GetComponent<Sensor_Bandit>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (
            isFacingRight && horizontal < 0f ||
            !isFacingRight && horizontal > 0f
        )
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        // Swap direction of sprite depending on walk direction
        if (inputX > 0)
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (inputX < 0)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        // Swap direction of sprite depending on walk direction
        // if (inputX > 0)
        //     transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        // else if (inputX < 0)
        //     transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //Check if character just landed on the ground
        if (!m_grounded && IsGrounded())
        {
            m_grounded = true;
            m_animator.SetBool("Grounded", m_grounded);
        }

        //Check if character just started falling
        if (m_grounded && IsGrounded())
        {
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        //Death
        if (Input.GetKeyDown("e"))
        {
            if (!m_isDead)
                m_animator.SetTrigger("Death");
            else
                m_animator.SetTrigger("Recover");

            m_isDead = !m_isDead;
        } //Hurt
        else if (Input.GetKeyDown("q"))
            m_animator.SetTrigger("Hurt"); //Attack
        else if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Attack");
        } //Change between idle and combat idle
        else if (Input.GetKeyDown("f"))
            m_combatIdle = !m_combatIdle;
        else if (Mathf.Abs(inputX) > Mathf.Epsilon)
            m_animator.SetInteger("AnimState", 2); //Combat Idle
        else
            m_animator.SetInteger("AnimState", 0);
    }
}
