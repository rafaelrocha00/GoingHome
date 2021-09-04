using System;
using System.Collections.Generic;
using UnityEngine;

public class ImageSequence : MonoBehaviour
{
    public Action FinishedShowingImageSequence;
    [SerializeField] List<GameObject> images = new List<GameObject>();
    [SerializeField] float timeBetweenSequences;
    int index = 0;
    float counter = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeImage();
            counter = 0f;
        }

        if (timeBetweenSequences == 0) return;

        counter += Time.deltaTime;
        if(counter >= timeBetweenSequences)
        {
            ChangeImage();
            counter = 0f;
        }
    }

    public void ChangeImage()
    {
        index++;
        if(index >= images.Count)
        {
            FinishedShowingImageSequence?.Invoke();
            return;
        }
        images[index].SetActive(true);
    }
}
