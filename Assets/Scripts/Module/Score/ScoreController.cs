using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Score
{
    public class ScoreController : ObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
        public void SetScore(int score)
        {
            _model.SetScore(score);
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
        }
    }
}