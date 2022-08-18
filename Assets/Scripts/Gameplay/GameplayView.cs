using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.EnemyAttack;
using Sekamar.SpaceShooter.Module.PlayerAttack;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sekamar.SpaceShooter.Module.Player;

namespace Sekamar.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public InputController InputController;
        public PlayerView playerView;
        public InputView inputView;
        public BulletContainerView bulletContainer;
        //public EnemyAttackView enemyAttackView;
        public MovementView movementView;
    }
}