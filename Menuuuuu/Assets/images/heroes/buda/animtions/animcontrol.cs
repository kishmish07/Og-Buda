using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontrol : MonoBehaviour
{
    private Animator _animator;
    public bool IsMoving {private get; set; }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("IsMoving", IsMoving);
    }
}
