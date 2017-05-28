﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Idle,
    jump
}
public class balljump : MonoBehaviour
{

    public State state = State.Idle;
    float time;
    public void Update()
    {
        if (state == State.jump)
        {
            jump();
        }

    }
    public void jump()
    {
        if (time > 0.5f)
        {
            time = 0.0f;
            state = State.Idle;
            return;

        }
        time += Time.deltaTime;
        float scale = 1.25f - Mathf.Abs(0.25f - time);
        transform.localScale = new Vector3(scale, scale, scale);




    }
}
