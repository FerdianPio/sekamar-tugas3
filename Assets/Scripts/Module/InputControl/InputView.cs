using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Movement;


namespace Sekamar.SpaceShooter.Module.InputControl
{
    public class InputView : BaseView
    {
        [SerializeField]
        private KeyCode _left, _right, _shoot;
        [SerializeField]
        private MovementView _movement;

        void Update()
        {
            if (ReadButtonDown(_left)) { _movement.Move(-1); }
            else if (ReadButtonDown(_right)) { _movement.Move(1); }
        }

        public bool ReadButtonDown(KeyCode _key)
        {
            if (Input.GetKey(_key))
            {
                return true;
            }
            else return false;
        }
    
    }
}
