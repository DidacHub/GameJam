using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class FXVolumeControl : MonoBehaviour
{
    [SerializeField] string volumeParameter = "MusicVolume";
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider slider;
    [SerializeField] float multiplier=30f;

    // Start is called before the first frame update
    void Awake()
    {
        slider.onValueChanged.AddListener(SliderValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SliderValueChanged(float value){
        mixer.SetFloat(volumeParameter, value:Mathf.Log10(value)* multiplier);
    }
}
