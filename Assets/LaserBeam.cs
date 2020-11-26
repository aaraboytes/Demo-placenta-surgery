using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    [SerializeField] GameObject _beamImage;
    private bool laserBeamEnabled = false;
    private Vector2 initialBeamScale;
    private AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.loop = true;
        initialBeamScale = _beamImage.transform.localScale;
    }
    private void Update()
    {
        if (laserBeamEnabled)
        {
            Debug.Log("bEAM ENABLED");
            if (Input.GetMouseButton(0))
            {
                float sin = (Mathf.Sin(Time.time * 4) + 1) / 2;
                _beamImage.transform.localScale = initialBeamScale + (Vector2.one * sin * 0.01f);
                ShotBeam();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                StopBeam();
            }
        }
        else
            StopBeam();
    }
    public void ShotBeam()
    {
        if(!_beamImage.activeInHierarchy)
            _beamImage.SetActive(true);
        if(!audio.isPlaying)
            audio.Play();
    }
    public void StopBeam()
    {
        if(_beamImage.activeInHierarchy)
            _beamImage.SetActive(false);
        if(audio.isPlaying)
            audio.Pause();
    }
    public void Switch()
    {
        laserBeamEnabled = !laserBeamEnabled;
    }
}
