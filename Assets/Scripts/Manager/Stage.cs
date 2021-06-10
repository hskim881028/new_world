using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Manager {
    public class Stage : MonoBehaviour {
        [SerializeField] private GameObject player;

        private EntityManager _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        private void Start() {
            SpawnPlayer();
        }

        private void SpawnPlayer() {
            var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
            var entityPlayer = GameObjectConversionUtility.ConvertGameObjectHierarchy(player, settings);
            var entity = _entityManager.Instantiate(entityPlayer);
            var startPosition = new Vector3(0, -2, 0);
            _entityManager.SetComponentData(entity, new Translation { Value = startPosition });
        }
    }
}