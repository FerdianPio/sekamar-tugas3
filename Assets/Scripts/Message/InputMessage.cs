using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Message
{
    public struct InputMessage
    {
        public int _inputValue { get; private set; }
        public InputMessage(int _i)
        {
            _inputValue = _i;
        }
    }

}
