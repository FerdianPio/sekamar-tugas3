using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
    public class EnemyPoolController : ObjectController<EnemyPoolController, EnemyPoolModel, IEnemyPoolModel, EnemyPoolView>
    {
        // public void Init(EnemyModel enemyPoolModel, EnemyPoolView enemyPoolView)
        // {
            
        // }

        public override void SetView(EnemyPoolView view)
        {
            base.SetView(view);
            InitPoolObject();
        }

        private void InitPoolObject()
        {
            /*_view.onMovePosition += OnMovePosition;
            _view.onDespawn += OnDespawnEnemy;*/
            _model.SetHeight(5);
            _model.SetWidth(11);
            Debug.Log(_model.PoolSize);
            // for (int i = 0; i < _model.PoolSize; i++)
            // {
            for (int x = 0; x < _model.Width; x++)
            {
                for (int y = 0; y < _model.Height; y++)
                {
                    // GameObject enemyPrefab = Resources.Load<GameObject>(@"Prefabs/Enemy");
                    // GameObject enemy = Object.Instantiate(enemyPrefab, _view.transform);

                    EnemyModel instanceModel = new EnemyModel();
                    GameObject instanceObject = GameObject.Instantiate(_view.prefab, new Vector3(x, y, 10), Quaternion.identity);
                    EnemyView instanceView = instanceObject.AddComponent<EnemyView>();
                    EnemyController instance = new EnemyController();
                    InjectDependencies(instance);
                    instance.Init(instanceModel, instanceView);
                    
                    SpawnEnemy(instanceObject);
                    instanceObject.name = $"Tile {x} {y}";
                    
                    _model._tiles[new Vector2(x, y)] = instanceObject;
                    // instanceObject.transform.parent = _view.gameObject.transform;
                    // if (x == 0 && y == 0) _leftDown = spawnedTile.transform;
                    // if (x == _model.Width-1 && y == _model.Height-1) _rightUp = spawnedTile.transform;
                }
            }
        }

        private void GridSystem(GameObject enemy)
        {
            for (int x = 0; x < _model.Width; x++)
            {
                for (int y = 0; y < _model.Height; y++)
                {
                    // var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y, 10), Quaternion.identity);
                    var spawnedTile = enemy;
                    spawnedTile.name = $"Tile {x} {y}";
                    
                    _model._tiles[new Vector2(x, y)] = spawnedTile;
                    spawnedTile.transform.parent = _view.gameObject.transform;
                    // if (x == 0 && y == 0) _leftDown = spawnedTile.transform;
                    // if (x == _model.Width-1 && y == _model.Height-1) _rightUp = spawnedTile.transform;
                }
            }

            foreach(GameObject _o in _model._tiles.Values)
            {
                _o.transform.position -= new Vector3(_model.Width / 2, _model.Height / 4);
                //Debug.Log(_o.transform.position);
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

        private void OnDespawnEnemy()
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