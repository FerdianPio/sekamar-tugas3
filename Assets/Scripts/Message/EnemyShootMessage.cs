using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Message
{
    public struct EnemyShootMessage
    {
        public bool trueOrFalse { get; private set; }

        public EnemyShootMessage(bool _trueOrFalse)
        {
            trueOrFalse = _trueOrFalse;
        }
    }
}