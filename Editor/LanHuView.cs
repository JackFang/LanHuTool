using UnityEngine;
using System.Collections.Generic;

namespace UnityEngine.UI.Tools
{
    public class LanHuView : ScriptableObject
    {
        /// <summary>
        /// 存放切图的文件夹路径
        /// </summary>
        public string path;

        public List<LanHuViewElement> elements = new List<LanHuViewElement>(0);
    }
}