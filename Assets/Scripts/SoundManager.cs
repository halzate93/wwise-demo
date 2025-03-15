using UnityEngine;

namespace CotA.Sound
{
    public class SoundManager : MonoBehaviour
    {
        public void PlayMusic ()
        {
            
        }

        public void StopMusic ()
        {

        }

        public void OnPlayerDamage (float healthPercentage)
        {
            AkUnitySoundEngine.PostEvent("Play_Music", gameObject);
            //AkUnitySoundEngine.SetRTPCValue("MusicVolume", 1f - healthPercentage);
        }
    }
}