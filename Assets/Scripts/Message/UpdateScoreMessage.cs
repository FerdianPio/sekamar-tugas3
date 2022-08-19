using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Message
{
    public struct UpdateScoreMessage
    {
        public int _scoreValue { get; private set; }
        public UpdateScoreMessage(int _score)
        {
            _scoreValue = _score;
        }
    }
}