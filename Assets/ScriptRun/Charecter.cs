using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum SIDE {Left,Mid,Right}

public class Charecter : MonoBehaviour
{
    public SIDE m_Side = SIDE.Mid;
    float NewXPos = 0f;
    [HideInInspector]
    public bool SwipeLeft,SwipeRight,SwipeUp,SwipeDown;
   
    
    public float XValue;
    private CharacterController m_char;
    private Animator m_Animator;
    private float x;
    public float SpeedDodge;
    public float JumpPower = 7f;
    private float y;
    public bool InJump;
    public bool InRoll;
    public float FwdSpeed = 7f;
    private float ColHeight;
    private float ColCenterY;
    void Start()
    {
        m_char = GetComponent<CharacterController>();
        ColHeight = m_char.height;
        ColCenterY = m_char.center.y;
        m_Animator = GetComponent<Animator>();
        transform.position = Vector3.zero;
    }

    
    void Update()
    {
        SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        SwipeUp = Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
        SwipeDown = Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
        if (SwipeLeft&& !InRoll)
        {
            if(m_Side == SIDE.Mid)
            {
                NewXPos = -XValue;
                m_Side = SIDE.Left;
            }else if(m_Side == SIDE.Right)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;
            }
        }
        else if (SwipeRight&& !InRoll)
        {
            if(m_Side == SIDE.Mid)
            {
                NewXPos = XValue;
                m_Side = SIDE.Right;
            }
            else if(m_Side == SIDE.Left)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;
            }
        }
        Vector3 moveVector = new Vector3(x - transform.position.x,y*Time.deltaTime, FwdSpeed*Time.deltaTime);
        x = Mathf.Lerp(x,NewXPos, Time.deltaTime * SpeedDodge);
        m_char.Move(moveVector);
        Jump();
        Roll();
    }
    public void Jump()
    {
        if(m_char.isGrounded)
        {
            if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Falling"))
            {
                m_Animator.Play("Landing");
                InJump = false;
            }
            if(SwipeUp)
            {
                y = JumpPower;
                m_Animator.CrossFadeInFixedTime("Jump",0.1f);
                InJump = true;
            }
        }else
        {
            y -= JumpPower * 2 * Time.deltaTime;
            if(m_char.velocity.y<-0.1f)
            m_Animator.Play("Falling");
        }
    }
    internal float RollCounter;
    public void Roll()
    {
        RollCounter -= Time.deltaTime;
        if(RollCounter <= 0f)
        {
            RollCounter = 0f;
            m_char.center = new Vector3(0, ColCenterY, 0);
            m_char.height = ColHeight;
            InRoll = false;
        }
        if(SwipeDown)
        {
            y -= 10f;
            m_char.center = new Vector3(0, ColCenterY/2f, 0);
            m_char.height = ColHeight/2f;
            m_Animator.CrossFadeInFixedTime("roll",0.1f);
            InRoll = true;
            InJump = false;
        }
    }
}
