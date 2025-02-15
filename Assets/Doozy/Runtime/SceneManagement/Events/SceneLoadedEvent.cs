﻿// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using System;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
namespace Doozy.Runtime.SceneManagement.Events
{
    /// <summary>
    /// UnityEvent used by the SceneDirector to notify when a Scene was loaded.
    /// <para/> Includes references to the loaded Scene and the used LoadSceneMode.
    /// </summary>
    [Serializable]
    public class SceneLoadedEvent  : UnityEvent<Scene, LoadSceneMode> { }
}
