using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipVisualParts : MonoBehaviour
{
    [SerializeField] List<GameObject> husks = new List<GameObject>();
    [SerializeField] List<GameObject> propulsion = new List<GameObject>();
    GameObject currentHusk;
    GameObject curentPropulsion;

    private void Start()
    {
        currentHusk = husks[0];
        curentPropulsion = propulsion[0];
    }

    public void ChangeHusk(int indexOfNewHusk)
    {
        currentHusk.SetActive(false);
        currentHusk = husks[indexOfNewHusk];
        currentHusk.SetActive(true);
    }

    public void ChangePropulsion(int indexOfNewPropulsion)
    {
        curentPropulsion.SetActive(false);
        curentPropulsion = propulsion[indexOfNewPropulsion];
        curentPropulsion.SetActive(true);
    }
}
