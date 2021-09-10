﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjSkin : MonoBehaviour
{
    [SerializeField] PnjChangeColor pnjChangeColor;

    [Header("Skin")]
    [SerializeField] GameObject[] armatures;
    [SerializeField] Material[] materialsList;
    [SerializeField] SkinnedMeshRenderer skinnedMeshRenderer;

    private void Awake()
    {
        //pnjChangeColor.onChangeColor += ChangeColor;

        //Active Random Armatures
        int armaturesIndexToActive = Random.Range(0, armatures.Length);
        armatures[armaturesIndexToActive].SetActive(true);

        //Active Random Color Skin

        int skinColorIndexToActive = Random.Range(0, materialsList.Length);
        Material[] mats = skinnedMeshRenderer.materials;
        mats[0] = materialsList[skinColorIndexToActive];
        skinnedMeshRenderer.materials = mats;
    }

}
