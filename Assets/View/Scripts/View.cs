using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eraUni.View
{
    /// <summary>
    /// 提供用于控制 View 风格的面板。
    /// </summary>
    [CreateAssetMenu(fileName = "View", menuName = "eraUni/View")]
    public class View : ScriptableObject
    {
        public bool canUpdate = true;
        // 全局
        // 背景、Header 和 Footer 的颜色
        // TMP 和 字体
        // 全局 Scrollbar 和 Scroll content (view) / header
        // 全局 input / footer

        // 元素 Elements
        // 标题和文本 Heading & Text
        public Color animatedIconColor = new Color(255, 255, 255, 255);
        // 按钮、横向和纵向和 Grid 布局的多个按钮
        // 进度条
        // 拖拽条 Slider
        // Toggle
        // 单选和多选菜单 Dropdown
        // Tooltip 提示符
        // 图片、图形（摄影棚）

        public GameObject[] gradients;
        [SerializeField]
        GameObject button;
        [SerializeField]
        GameObject inputField;

        public GameObject Button { get => button;}
        public GameObject InputField { get => inputField;}
    }
}

