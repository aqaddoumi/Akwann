//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CoreEntity {

    public AssetPathComponent assetPath { get { return (AssetPathComponent)GetComponent(CoreComponentsLookup.AssetPath); } }
    public bool hasAssetPath { get { return HasComponent(CoreComponentsLookup.AssetPath); } }

    public void AddAssetPath(string newValue) {
        var index = CoreComponentsLookup.AssetPath;
        var component = (AssetPathComponent)CreateComponent(index, typeof(AssetPathComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAssetPath(string newValue) {
        var index = CoreComponentsLookup.AssetPath;
        var component = (AssetPathComponent)CreateComponent(index, typeof(AssetPathComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAssetPath() {
        RemoveComponent(CoreComponentsLookup.AssetPath);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class CoreMatcher {

    static Entitas.IMatcher<CoreEntity> _matcherAssetPath;

    public static Entitas.IMatcher<CoreEntity> AssetPath {
        get {
            if (_matcherAssetPath == null) {
                var matcher = (Entitas.Matcher<CoreEntity>)Entitas.Matcher<CoreEntity>.AllOf(CoreComponentsLookup.AssetPath);
                matcher.componentNames = CoreComponentsLookup.componentNames;
                _matcherAssetPath = matcher;
            }

            return _matcherAssetPath;
        }
    }
}