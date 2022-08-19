using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Sekamar.SpaceShooter.Module.Score
{
    public class ScoreView : ObjectView<IScoreModel>
    {
        [SerializeField] private Text _scoreText;

        protected override void InitRenderModel(IScoreModel model)
        {
            _scoreText.text = $"Score: {model._score.ToString()}";
        }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            _scoreText.text = $"Score: {model._score.ToString()}";
        }
    }
}