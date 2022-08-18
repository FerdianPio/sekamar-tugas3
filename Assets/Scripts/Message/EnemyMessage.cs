using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Message
{
    public struct EnemyMessage
    {
        public Transform _leftDown { get; private set; }
        public Transform _rightUp { get; private set; }
        public EnemyMessage(Transform leftDown, Transform rightUp)
        {
            _leftDown = leftDown;
            _rightUp = rightUp;
        }
    }

}
