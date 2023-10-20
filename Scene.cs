using System.Collections.Generic;
using Raytracer.Materials;
using Raytracer.Objects;

namespace Raytracer
{
    public class Scene
    {
        public readonly ObjectList World;
        
        private static readonly IMaterial _GroundMaterial = new Lambertian(Color.White * 0.5d);
        private readonly Sphere _ground = new(Vector3.Down * 1000d, 1000, _GroundMaterial);
        
        private static readonly IMaterial _GlassMaterial = new Dielectric(1.5d);
        private readonly Sphere _glassSphere = new(new Vector3(0d, 1d, 0d), 1d, _GlassMaterial);
        
        private static readonly IMaterial _FlatMaterial = new Lambertian(new Color(0.8d, 0.1d, 0.2d));
        private readonly Sphere _lambertianSphere = new(new Vector3(-4.0d, 1.0d, 0d), 1d, _FlatMaterial);
        
        private static readonly IMaterial _MetalMaterial = new Metal(new Color(0.7d, 0.6d, 0.5d), 0d);
        private readonly Sphere _metalSphere = new(new Vector3(4.0d, 1d, 0d), 1d, _MetalMaterial);

        public Scene()
        {
            World = new ObjectList
            {
                _ground,
                _glassSphere,
                _lambertianSphere,
                _metalSphere
            };
            
            World.AddRange(CreateSpheres());
        }
        
        public static IEnumerable<IObject> CreateSpheres()
        {
            List<IObject> spheres = new();

            const double height = 0.2d;
            const double radius = 0.9d;
            const double sphereRadius = 0.2d;
            const int numSpheres = 16;

            for (int i = 0; i < numSpheres; i++)
            {
                double chooseMaterial = Global.RandomDouble();

                Vector3 center = Vector3.RandomInUnitCircle() * radius;
                center.Z = height;
                (center.Y, center.Z) = (center.Z, center.Y);

                if (center.Diff(new Vector3(4d, 0.2, 0)).Magnitude > radius)
                    continue;

                IMaterial sphereMaterial = chooseMaterial switch
                {
                    < 0.8  => new Lambertian(Color.Random().Hadamard(Color.Random())),
                    < 0.95 => new Metal(Color.Random(0.5, 1d), Global.RandomDouble() / 2d),
                    _      => new Dielectric(1.5)
                };

                spheres.Add(new Sphere(center, sphereRadius, sphereMaterial));
            }

            return spheres;
        }
    }
}