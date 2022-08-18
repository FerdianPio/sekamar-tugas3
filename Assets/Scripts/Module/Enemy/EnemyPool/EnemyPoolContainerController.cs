using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
	public class EnemyPoolContainerController : ObjectController<EnemyPoolContainerController, EnemyPoolContainerView>
	{
		public void CreateInstanceObject()
		{
			EnemyMovementModel instanceModel = new EnemyMovementModel();
			GameObject instanceObject = GameObject.Instantiate(Resources.Load<GameObject>(@"Prefabs/Enemy"), Vector3.zero, Quaternion.identity);
			EnemyMovementView instanceView = instanceObject.GetComponent<EnemyMovementView>();
			EnemyMovementController instance = new EnemyMovementController();
			InjectDependencies(instance);
			instance.Init(instanceModel, instanceView);
		}
	}
}