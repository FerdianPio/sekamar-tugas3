using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.GridSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyMovementController : ObjectController<EnemyMovementController, EnemyMovementView>
    {
        public int _direction { get; private set; }

        public void Init()
        {
            _view.OnGamePlay += OnGamePlay;
        }

        private void OnGamePlay()
        {
            SetDirection(-1);
        }

        public void SetDirection(int _dir)
        {
            _direction = _dir;
            _view.Move(_direction);
            //SwitchOnEdge(gridSystemController.GetLeftDown, gridSystemController.GetRightUp);
        }
        public void SwitchOnEdge(Transform leftDown, Transform rightUP)
        {
            if (leftDown.transform.position.x < -Camera.main.orthographicSize + 1 || rightUP.transform.position.x > Camera.main.orthographicSize - 1)
            {
                SetDirection(-_direction);
            }

        }

        public override void SetView(EnemyMovementView view)
        {
            base.SetView(view);
            Init();
        }
    }

}
