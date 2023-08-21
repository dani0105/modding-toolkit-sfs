using SFS.IO;
using SFS.Parsers.Json;
using UnityEngine;

namespace SFS.IO
{
    public abstract class SettingsBase<T> : MonoBehaviour where T : new()
    {
        public T settings;

        protected abstract string FileName { get; }

        private FilePath Path => FileLocations.GetSettingsPath(FileName);

        protected abstract void OnLoad();

        protected void Save()
        {

        }

        protected void Load()
        {
        }
    }
}