﻿using System;
using Helper;
using UnityEngine;

namespace Movement
{
    public class PlayerInput : MonoBehaviour
    {
        private Move _move;

        private int horizontal = 0, vertical = 0;

        private enum Axis
        {
            Horizontal,
            Vertical
        }

        private void Awake()
        {
            _move = GetComponent<Move>();
        }

        private void Update()
        {
            horizontal = 0;
            vertical = 0;

            GetKeyboardInput();
            
            SetMovement();
        }

        private void GetKeyboardInput()
        {
            horizontal = GetAxisRaw(Axis.Horizontal);
            vertical = GetAxisRaw(Axis.Vertical);
            
            if (horizontal != 0)
            {
                vertical = 0;
            }
            
        }

        private void SetMovement()
        {
            if (vertical != 0)
            {
                _move.SetInputDirection((vertical ==1) ? 
                    PlayerDirection.UP : PlayerDirection.DOWN);
            }else if (horizontal != 0)
            {
                _move.SetInputDirection((horizontal ==1) ? 
                        PlayerDirection.RIGHT : PlayerDirection.LEFT);
            }
        }

        private int GetAxisRaw(Axis axis)
        {
            if (axis == Axis.Horizontal)
            {
                bool left = Input.GetKeyDown((KeyCode.A));
                bool right = Input.GetKeyDown(KeyCode.D);

                if (left)
                {
                    return -1;
                }

                if (right)
                {
                    return 1;
                }

                return 0;
            }else if (axis == Axis.Vertical)
            {
                bool up = Input.GetKeyDown((KeyCode.W));
                bool down = Input.GetKeyDown(KeyCode.S);
                
                if (up)
                {
                    return 1;
                }

                if (down)
                {
                    return -1;
                }

                return 0;
            }
            return 0;
        }
    }
}