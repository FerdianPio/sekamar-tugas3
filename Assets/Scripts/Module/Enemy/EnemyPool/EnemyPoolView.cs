using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
    public class EnemyPoolView : ObjectView<IEnemyPoolModel>
    {
        public System.Action onMovePosition;
        public System.Action onDespawn;

        private void Update()
        {
            onMovePosition?.Invoke();
            onDespawn?.Invoke();
        }

        protected override void InitRenderModel(IEnemyPoolModel model)
        {
            // taro posisinya dibawah enemy
            //throw new System.NotImplementedException();
            transform.position = _model.Position;
        }

        protected override void UpdateRenderModel(IEnemyPoolModel model)
        {
            // taro posisinya dibawah enemy
            //throw new System.NotImplementedException();
            transform.position = _model.Position;
        }
    }
}