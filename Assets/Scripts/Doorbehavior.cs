using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Doorbehavior : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public Collider doorCollider;


    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            _animator.SetBool("Open", true);
            doorCollider.enabled = false;
        }
    }
}
