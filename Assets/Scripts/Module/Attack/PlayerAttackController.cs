using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
    public class PlayerAttackController : ObjectController<PlayerAttackController, PlayerAttackView>
    {
        public int trigger { get; private set; }

        public void VerifySpawn(int tr)
        {
            trigger = tr;
            _view.SpawnPlayerBullet(trigger);
        }
    }
}