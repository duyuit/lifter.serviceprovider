namespace lifter.serviceprovider
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(fileName = "SoundDataSO", menuName = "SoundDataSO", order = 1)]
    public class SoundDataSO : ScriptableObject
    {
        public List<SoundData> SoundDatas;
    }
 
}
