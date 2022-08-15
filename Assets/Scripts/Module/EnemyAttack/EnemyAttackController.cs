using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyAttack
{
    public class EnemyAttackController : ObjectController<EnemyAttackController, EnemyAttackView>
    {
        public int trigger { get; private set; }

        public void VerifySpawn(int tr)
        {
            trigger = tr;
            _view.SpawnEnemyBullet(trigger);
        }
    }
}