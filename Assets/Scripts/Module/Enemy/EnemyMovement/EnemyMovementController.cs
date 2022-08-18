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
        public Vector2 _direction { get; private set; }

        public void Init()
        {
            _view.OnGamePlay += OnGamePlay;
        }

        private void OnGamePlay()
        {
            SetDirection(-1);
        }

        public void SetDirection(float _dir)
        {
            Debug.Log("Test");
            _direction = new Vector2(_dir,0);
            _view.Move(_direction);
            //SwitchOnEdge(gridSystemController.GetLeftDown, gridSystemController.GetRightUp);
        }
        public void SwitchOnEdge(Transform leftDown, Transform rightUP)
        {
            if (leftDown.transform.position.x < -Camera.main.orthographicSize + 1 || rightUP.transform.position.x > Camera.main.orthographicSize - 1)
            {
                SetDirection(-_direction.x);
            }

        }

        public override void SetView(EnemyMovementView view)
        {
            base.SetView(view);
            Init();
        }
    }

}
