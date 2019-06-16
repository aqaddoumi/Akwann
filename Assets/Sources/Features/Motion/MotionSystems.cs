using Entitas;

public class MotionSystems : Feature  {
    public MotionSystems(Contexts contexts) {
        Add(new UpdatePositionByVelocitySystem(contexts));
    }	
}