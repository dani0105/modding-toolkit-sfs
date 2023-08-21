using System;



[Serializable]
// ReSharper disable InconsistentNaming
public class AssetBundlePack
{
    public byte[] MacBuild;

    public byte[] WindowsBuild;

    public byte[] CodeAssembly;

    public byte[] Data => WindowsBuild;
}
