﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Subsets.Message2
{
    public class CommandBinder : MonoBehaviour
    {
        public String SourceEvent;
        public void Awake()
        {
            EventTrigger trigger = GetComponent<EventTrigger>();
        }

        public void Raise()
        {
        }
    }
}