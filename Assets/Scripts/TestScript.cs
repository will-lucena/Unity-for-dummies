using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Animator _anim;

    [SerializeField] private KeyCode blinkAction;
    [SerializeField] private KeyCode moveAction;
    [SerializeField] private KeyCode scaleAction;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(blinkAction))
        {
            blink();
        }

        if (Input.GetKeyDown(scaleAction))
        {
            scale();
        }

        if (Input.GetKeyDown(moveAction))
        {
            move();
        }
    }

    public void blink()
    {
        _anim.SetTrigger("Blink");
    }
    
    public void move()
    {
        _anim.SetTrigger("Move");
    }
    
    public void scale()
    {
        _anim.SetTrigger("Scale");
    }
}
