using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.GridSystem
{
    public class GridSystemController : ObjectController<GridSystemController, GridSystemView>
    {
        public GameObject _leftDown { get; }
        public GameObject _rightUp { get; }

        public override void SetView(GridSystemView view)
        {
            base.SetView(view);
        }
    }

}
