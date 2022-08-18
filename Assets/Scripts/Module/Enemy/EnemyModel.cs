using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyModel : BaseModel
    {
        public int _point { get; private set; }

        public void SetPoint(int point)
        {
            _point = point;
            SetDataAsDirty();
        }
    }

}
