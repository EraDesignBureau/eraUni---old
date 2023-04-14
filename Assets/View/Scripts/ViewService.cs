using Michsky.UI.ModernUIPack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eraUni.View
{
    /// <summary>
    /// 为 Front Controller 提供有关 View 层的 API。
    /// 用于生成、配置、更新 View 相关的 Components 和 Elements。
    /// 这里的配置特指通过 View 改变设置，并映射到 prefabs 和游戏的 instance 中。
    /// </summary>
    public class ViewService
    {
        public View GetView()
        {
            return Resources.Load<View>("MainView");
        }
    }
}

