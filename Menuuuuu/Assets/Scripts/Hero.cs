using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    public int health = 100;


    public Animator animator;


    public List<Skill> skills = new List<Skill>();


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
        if (IsGrounded())
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

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        return hit.collider != null;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

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


public class Skill
{
    public string name;
    public int cooldown;
    public int damage;

    public Skill(string name, int cooldown, int damage)
    {
        this.name = name;
        this.cooldown = cooldown;
        this.damage = damage;
    }

    public void Use()
    {

        UnityEngine.Debug.Log($"Used {name} skill");
    }
}