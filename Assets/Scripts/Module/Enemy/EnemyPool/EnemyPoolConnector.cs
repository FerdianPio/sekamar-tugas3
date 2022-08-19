using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
    public class EnemyPoolConnector : BaseConnector
    {
        private EnemyPoolController _enemyPoolController;

        protected override void Connect()
        {
            // Subscribe RemoveDarahPlayerMessage
            // Subscribe RemoveDarahObstacleMessage
            //throw new System.NotImplementedException();
        }

        protected override void Disconnect()
        {
            // Unsubscribe RemoveDarahPlayerMessage
            // Unsubscribe RemoveDarahObstacleMessage
            //throw new System.NotImplementedException();
        }
    }
}