using Agate.MVC.Base;
using Sekamar.SpaceShooter.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.GridSystem
{
    public class GridSystemController : ObjectController<GridSystemController, GridSystemView>
    {
        public Transform _leftDown { get; }
        public Transform _rightUp { get; }

        public void Init(Transform a, Transform b)
        {
            Publish<EnemyMessage>(new EnemyMessage(a,b));
        }

        public override void SetView(GridSystemView view)
        {
            base.SetView(view);
            Init(view._leftDown, view._rightUp);
        }
    }

}
