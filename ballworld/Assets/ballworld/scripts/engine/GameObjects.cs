using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ballworld.scripts.engine
{
    public static class GameObjects
    {
        public static void setAlpha(this GameObject gameObject, float value)
        {
            Color color = gameObject.GetComponent<SpriteRenderer>().color;
            color.a = value;
            gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }
}
