using UnityEngine;

namespace Global.Function
{
    public static class GlobalUtils
    {
        public static Vector3 GetRandomDir() 
        {
            return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0).normalized;
        }
    }
}
