using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Module.Attack;

namespace Sekamar.SpaceShooter.Module.InputControl
{
    public class InputView : BaseView
    {
        public event System.Action OnLeftPressed;
        public event System.Action OnRightPressed;

        [SerializeField]
        private KeyCode _left, _right, _shoot;
        [SerializeField]
        private MovementView _movement;
        [SerializeField]
        private AttackView _attack;

        void Update()
        {
            if (ReadButtonDown(_left)) { OnLeftPressed?.Invoke(); }
            else if (ReadButtonDown(_right)) { OnRightPressed?.Invoke(); }

            if (ReadButtonDown(_shoot)) { _attack.SpawnBullet(); }
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
