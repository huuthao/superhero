using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float atkRate;
    private Animator t_anim;
    private float t_curAtkRate;
    private bool t_isatked;

    private void Awake()
    {
        t_curAtkRate = atkRate;
        t_anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !t_isatked)
        {
            
            if (t_anim)
                t_anim.SetBool(Const.ATTACK_ANIM, true);
            t_isatked = true;
        }
        if (t_isatked)
        {
            t_curAtkRate -= Time.deltaTime;
            if(t_curAtkRate <= 0)
            {
                t_isatked = false;
                t_curAtkRate = atkRate;
            }
        }
    }
    public void ResetAtkAmin()
    {
        if(t_anim)
            t_anim.SetBool(Const.ATTACK_ANIM,false);
    }
}
