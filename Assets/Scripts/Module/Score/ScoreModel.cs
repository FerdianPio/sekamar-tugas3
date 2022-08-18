using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Score
{
    public class ScoreModel : BaseModel, IScoreModel
    {
        public int _score {get; private set;}

        public void SetScore(int score)
        {
            _score = score;
            SetDataAsDirty();
        }
    }
}