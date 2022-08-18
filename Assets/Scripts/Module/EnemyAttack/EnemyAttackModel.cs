using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyAttack
{
    public class EnemyAttackModel : BaseModel
    {
        public float Interval { get; private set; } = 2f;
        public float RunTime { get; private set; } = 0f;

        public void SetInterval(float interval)
        {
            Interval = interval;
            SetDataAsDirty();
        }

        public void SetRunTime(float runTime)
        {
            RunTime += runTime;
            SetDataAsDirty();
        }

        public void SetRunTimeToZero()
        {
            RunTime = 0;
            SetDataAsDirty();
        }
    }
}