using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero2 : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    public int health = 100;


    public Animator animator;


    public List<Skill> skills = new List<Skill>();
    private animcontrol _animations;
    [SerializeField] private SpriteRenderer _characterSprite;
    [SerializeField] private ContactFilter2D _platform;
    private bool _isOnPlatform => GetComponent<Rigidbody2D>().IsTouching(_platform);


    public void MoveLeft()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        animator.SetBool("isMoving", true);

    }

    public void MoveRight()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        animator.SetBool("isMoving", true);
   
    }

    public void Jump()
    {
        if (_isOnPlatform == true)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("jump");
        }
    }

    public void Attack()
    {
        animator.SetTrigger("attack");
    }

    public void DodgeDown()
    {
        animator.SetTrigger("dodgeDown");
    }

    public void UseSkill(int skillIndex)
    {
        if (skillIndex >= 0 && skillIndex < skills.Count)
        {
            skills[skillIndex].Use();
        }
    }
    
    private void Start()
    {
        _animations = GetComponentInChildren<animcontrol>();
    }



    void Update()
    {   
        _animations.IsMoving = false;
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
            _characterSprite.flipX = true;
            _animations.IsMoving = true;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
            _characterSprite.flipX = false;
            _animations.IsMoving = true;
        }
        _animations.IsMoving = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DodgeDown();
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            UseSkill(0);
        }
        
    }
    
}


