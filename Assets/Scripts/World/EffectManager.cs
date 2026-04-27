using System.Collections;
using System.Collections.Generic;
using SFS.World;
using UnityEngine;

namespace SFS.World
{
    public class EffectManager : MonoBehaviour
    {
        private class Effect
        {
            private readonly Transform effect;

            public Coroutine lifecycleCoroutine;

            public Effect(Transform effect)
            {
                this.effect = effect;
            }

            public void Destroy()
            {
                if (effect != null)
                {
                    Object.Destroy(effect.gameObject);
                }
                main.StopCoroutine(lifecycleCoroutine);
                main.effects.Remove(this);
            }
        }

        private static EffectManager main;

        public Transform explosionPrefab;

        public Transform explosionSoundPrefab;

        public Transform waterSplashPrefab;

        private List<Effect> effects = new List<Effect>();

        private void Awake()
        {
            main = this;
        }

        public static void CreateExplosion(Vector3 position, float size)
        {

        }

        public static void CreatePartOverheatEffect(Vector3 position, float size)
        {

        }

        public static void CreateSplashEffect(Vector3 position, float size)
        {
        }

        public static Transform CreateEffect(Transform prefab, Vector3 position, float duration)
        {
            return null;
        }

        public static void ClearEffects()
        {

        }

    }
}