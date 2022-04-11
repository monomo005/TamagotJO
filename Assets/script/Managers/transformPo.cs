using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformPo : MonoBehaviour
{
    public static transformPo instance;
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        
    }
    public void Date()
    {
        if(ExpStat.instance.nextEXPtoLevelUp >=200)
        {
            transform.position = new Vector2 (transform.position.x + -26f ,transform.position.y + 35f );
            transform.localScale = new Vector2 (transform.localScale.x + 0.3f,transform.localScale.y + 0.3f);
        }
    }
    public void Date2()
    {
        if(ExpStat.instance.nextEXPtoLevelUp >=300)
        {
            transform.position = new Vector2 (transform.position.x + -26f ,transform.position.y + -20f );
            transform.localScale = new Vector2 (transform.localScale.x + 0.3f,transform.localScale.y + 0.3f);
        }
    }
}
