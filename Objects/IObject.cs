namespace Raytracer
{
    public interface IObject
    {
        public const float DEFAULT_MIN = 0.001f;
        
        public const float DEFAULT_MAX = float.MaxValue;
        
        Hit? Hit(Ray ray, float minimumDistance = DEFAULT_MIN, float maximumDistance = DEFAULT_MAX);
    }
}