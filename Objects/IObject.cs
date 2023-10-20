namespace Raytracer
{
    public interface IObject
    {
        public const double DEFAULT_MIN = 0.001;
        
        public const double DEFAULT_MAX = double.MaxValue;
        
        Hit? Hit(Ray ray, double minimumDistance = DEFAULT_MIN, double maximumDistance = DEFAULT_MAX);
    }
}