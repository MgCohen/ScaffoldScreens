using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Scaffold.Screens
{
    internal class ScreenBuilder
    {
        public T Load<T>() where T: IUIScreen
        {
            return default(T);
        }

        public List<IUIScreen> FindAllScreens()
        {
            return null;
        }


    }
}