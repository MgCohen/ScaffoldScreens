using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Scaffold.Screens
{
    public class ScreenManager : MonoBehaviour
    {
        private Dictionary<Type, IUIScreen> _screenCollection = new Dictionary<Type, IUIScreen>();

        private Queue<IUIScreen> _pendingScreens;
        private List<IUIScreen> _openScreens;

        private T Show<T>() where T : IUIScreen
        {
            return default(T);
        }

        private T Load<T>() where T: IUIScreen
        {
            return default(T);
        }
    }
}