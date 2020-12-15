using System.IO;
using UnityEngine;

public class SimpleAssetBundleBasedSpawner : MonoBehaviour
{
    [SerializeField]
    private string _assetBundleName;
    [SerializeField]
    private string _prefabName;
    
    private void Start()
    {
        var assetBundle
            = AssetBundle
                .LoadFromFile(Path.Combine(Application.streamingAssetsPath, 
                                           _assetBundleName));
        
        if (assetBundle == null) {
            Debug.Log("Failed to load AssetBundle " + _assetBundleName);
            return;
        }
        
        var prefab = assetBundle.LoadAsset<GameObject>(_prefabName);
        Instantiate(prefab, transform);
    }
}
