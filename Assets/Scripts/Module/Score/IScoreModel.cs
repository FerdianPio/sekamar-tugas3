using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Score
{
    public interface IScoreModel: IBaseModel
    {
        public int _score {get;}
    }
}