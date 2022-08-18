using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
	public class BulletController : ObjectController<BulletController, BulletModel, BulletView>
	{
		public void Init(BulletModel model, BulletView view)
		{
			_model = model;
			SetView(view);
		}
	}

}
