using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
	public class BulletController : ObjectController<BulletController, BulletModel, BulletView>
	{
		public void Init(BulletModel model, BulletView view)
		{
			view.OnBulletSpawn += OnBulletSpawn;
			_model = model;
			SetView(view);
		}

        private void OnBulletSpawn()
        {
			_view.transform.Translate(new Vector2(0, 5) * Time.deltaTime);
        }
    }

}
