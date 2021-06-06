using Unity.Entities;

namespace ECS.System {
    public class EnemyMovementSystem : SystemBase {
        protected override void OnUpdate() {
            // var deltaTime = Time.DeltaTime;
            // Entities.ForEach((ref Translation trans, in EnemyTag data) => {
            //     trans.Value.x += /*data.Position.x **/ deltaTime;
            //     trans.Value.y += /*data.Position.y **/ deltaTime;
            // }).ScheduleParallel();
        }
    }
}