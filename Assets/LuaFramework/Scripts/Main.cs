using UnityEngine;
using System.Collections;
using Config;

namespace LuaFramework {
    /// <summary>
    /// 框架主入口
    /// </summary>
    public class Main : MonoBehaviour {

        void Start() {
            ConfigMgr.Instance.Parse();
            AppFacade.Instance.StartUp();   //启动游戏
        }
    }
}