using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Attack;
using Sekamar.SpaceShooter.Module.Enemy;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Module.GridSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public InputController InputController;
        public InputView inputView;
        public AttackView attackView;
        public MovementView movementView;
        public GridSystemView gridSystemView;
        //public EnemyView enemyView;
        public EnemyMovementView enemyMovementView;
    }
}