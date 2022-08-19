using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.EnemyAttack;
using Sekamar.SpaceShooter.Module.PlayerAttack;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sekamar.SpaceShooter.Module.Player;
using Sekamar.SpaceShooter.Module.Enemy;
using Sekamar.SpaceShooter.Module.EnemyPool;

namespace Sekamar.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public InputController InputController;
        public PlayerView playerView;
        public InputView inputView;
        public BulletContainerView bulletContainer;
        public MovementView movementView;
        public EnemyPoolView enemyPoolView;
        //public EnemyView enemyView;
    }
}