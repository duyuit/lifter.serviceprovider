using System.Collections.Generic;

namespace lifter.serviceprovider
{
    using System;
    using UnityEngine;

    [Serializable]
    public class SoundData
    {
        public string id;
        public AudioClip audioClip;
        public float volume = 1;
    }

    public class SoundController : Singleton<SoundController>
    {
        private Dictionary<string, SoundData> dictSoundData;

        public void Initialize()
        {
            SoundDataSO soundDataSo = Resources.Load<SoundDataSO>("SoundDataSO");
            if (soundDataSo == null)
            {
                Debug.LogError("Can't find SoundDataSO in Resources folder");
                return;
            }
            
            dictSoundData = new Dictionary<string, SoundData>();
            foreach (var s in soundDataSo.SoundDatas)
            {
                dictSoundData[s.id] = s;
            }
        }
    }
}