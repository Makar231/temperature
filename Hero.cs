using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private float _currentTemperature;
    [SerializeField] private TMP_Text _temperatureText;

    private void Start()
    {
        _currentTemperature = 34;
    }

    private void Update()
    {
        _temperatureText.text = _currentTemperature.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent(out Bonfire bonfire))
        {
            _currentTemperature = 36.6f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.TryGetComponent(out Bonfire bonfire))
        {
            _currentTemperature = 34;
        }
    }
}
