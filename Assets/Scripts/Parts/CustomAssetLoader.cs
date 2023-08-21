// SFS.Parts.CustomAssetsLoader
using System;
using System.Collections.Generic;
using System.Text;
using ModLoader;
using Newtonsoft.Json;
using SFS.IO;

namespace SFS.Parts
{
    public static class CustomAssetsLoader
    {
    
        private static bool loadedAssetPacks;

        private static readonly StringBuilder Report = new StringBuilder();

        public static bool finishedLoading;

        private static bool loadedTexturePacks;

        private static bool loadingShadowTextures;

        private static JsonSerializer serializer;

        private static JsonSerializer serializerForShadowTexture;

        private const string UpdateLegacyPackMessage = "Game detected lagacy formatted pack. Do you want to convert it to new format? If not, you will not be able to use this pack";

        private static bool? confirmationResult;

        private static FolderPath currentPack;

        private static Dictionary<string, ShadowTexture> shadowTexturesDictionary;

        public static FolderPath CustomAssetsFolder => Loader.ModsFolder.Extend("Custom Assets").CreateFolder();

    }
}