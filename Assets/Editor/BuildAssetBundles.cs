using UnityEditor;
using System.IO;
using UnityEngine;

public class BuildAssetBundles
{
    [MenuItem("Assets/Build Asset Bundles in Project")]
    private static void BuildAssetBundlesInProject()
    {
        var assetBundleDirectory = Application.streamingAssetsPath;
        
        if(!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
                                        BuildAssetBundleOptions.None,
                                        BuildTarget.Android);
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
                                        BuildAssetBundleOptions.None,
                                        BuildTarget.StandaloneOSX);
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
                                        BuildAssetBundleOptions.None,
                                        BuildTarget.iOS);
    }
}
