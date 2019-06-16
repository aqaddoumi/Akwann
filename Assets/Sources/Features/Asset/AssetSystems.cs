using Entitas;

public class AssetSystems : Feature  {
    public AssetSystems(Contexts contexts) {
        Add(new LoadAssetByAssetPathSystem(contexts));
    }	
}