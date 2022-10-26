using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidiing : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D boxCollider;

    [SerializeField]
    private float offsetY = -0.1f;
    [SerializeField]
    private float sizeY = 0.1f;

    private bool isSliding = false;

    private Vector2 startOffset;
    private Vector2 startSize;

    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        startOffset = boxCollider.offset;
        startSize = boxCollider.size;
    }

    void Update()
    {
        bool canSlide = !animator.GetBool("IsFly");
        if (canSlide == false) return;
        if (isSliding)
        {
            EndSlide();
        }
        else
        {
            StartSlide();
        }
    }
    private void StartSlide()
    {
        bool isKeyDown = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
        if (isKeyDown)
        {
            boxCollider.offset = new Vector2(startOffset.x, offsetY);
            boxCollider.size = new Vector2(startSize.x, sizeY);
            isSliding = true;
            animator.SetBool("IsDodge", isSliding);
        }
    }
    private void EndSlide()
    {
        bool isKeyUp = Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.DownArrow);
        if (isKeyUp)
        {
            boxCollider.offset = startOffset;
            boxCollider.size = startSize;

            isSliding = false;
            animator.SetBool("IsDodge", isSliding);
        }
    }
}
