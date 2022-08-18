using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
    public class EnemyPoolController : ObjectController<EnemyPoolController, EnemyPoolModel, IEnemyPoolModel, EnemyPoolView>
    {
        public void Init(EnemyPoolModel enemyPoolModel, EnemyPoolView enemyPoolView)
        {
            
        }

        public override void SetView(EnemyPoolView view)
        {
            base.SetView(view);
            InitPoolObject();
        }

        private void InitPoolObject()
        {
            _view.onMovePosition += OnMovePosition;
            _view.onDespawn += OnDespawnBullet;
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject enemyPrefab = Resources.Load<GameObject>(@"Prefabs/Enemy");
                GameObject enemy = Object.Instantiate(enemyPrefab, _view.transform);
                SpawnEnemy(enemy);
            }
        }

        private void SpawnEnemy(GameObject enemy)
        {
            // get posisi spawn Y untuk bullet
            //Vector3 obstacleYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);

            // set posisi spawn Y untuk bullet
            //bullet.transform.localPosition = _model.SpawnPoint + obstacleYPosition;

            // set posisi spawn X untuk bullet
            //_model.MoveSpawnPoint();

            enemy.SetActive(true);
            _model.EnqueueEnemy(enemy);
        }

        private void OnMovePosition()
        {
            float enemySpeedAmbilDariInterface = 1f;

            if (_model.IsPlaying)
            {
                Vector3 position = _model.Position + (Vector3.down * enemySpeedAmbilDariInterface * Time.deltaTime);
                _model.SetPosition(position);
            }
        }

        private void OnDespawnBullet()
        {
            float frontObstaclePosition = _model.GetObstacleInFront().transform.position.y;
            float despawnPosition = _model.DespawnPosition.y;
            if (frontObstaclePosition <= despawnPosition)
            {
                GameObject enemy = _model.DequeueEnemy();
                enemy.SetActive(false);
                SpawnEnemy(enemy);
            }
        }
    }
}