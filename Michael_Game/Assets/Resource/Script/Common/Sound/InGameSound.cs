﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSound : BaseObject {

    private string audioClipName = "";

    BGMPlayer player;

    void Start()
    {
        Singleton<SoundPlayer>.instance.PlayBGM("Water", 0.0f, true);
        Singleton<SoundPlayer>.instance.PlayBGM("Wind", 0.0f, true);
    }
	
}
