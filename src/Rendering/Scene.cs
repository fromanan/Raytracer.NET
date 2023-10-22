using System.Collections.Generic;
using System.Numerics;
using Raytracer.Materials;
using Raytracer.Objects;

namespace Raytracer.Rendering
{
    public class Scene
    {
        public readonly ObjectList World;
        
        private static readonly IMaterial _GroundMaterial = new Lambertian(Color.White * 0.5f);
        private readonly Sphere _ground = new(-Vector3.UnitY * 1000f, 1000, _GroundMaterial);
        
        private static readonly IMaterial _GlassMaterial = new Dielectric(1.5f);
        private readonly Sphere _glassSphere = new(new Vector3(0f, 1f, 0f), 1f, _GlassMaterial);
        
        private static readonly IMaterial _FlatMaterial = new Lambertian(new Vector3(0.8f, 0.1f, 0.2f));
        private readonly Sphere _lambertianSphere = new(new Vector3(-4.0f, 1.0f, 0f), 1f, _FlatMaterial);
        
        private static readonly IMaterial _MetalMaterial = new Metal(new Vector3(0.7f, 0.6f, 0.5f), 0f);
        private readonly Sphere _metalSphere = new(new Vector3(4.0f, 1f, 0f), 1f, _MetalMaterial);

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

            const float height = 0.2f;
            const float radius = 0.9f;
            const float sphereRadius = 0.2f;
            const int numSpheres = 16;

            for (int i = 0; i < numSpheres; i++)
            {
                float chooseMaterial = Global.RandomFloat();

                Vector3 center = VectorUtils.RandomInUnitCircle() * radius;
                center.Z = height;
                (center.Y, center.Z) = (center.Z, center.Y);

                if ((center - new Vector3(4f, 0.2f, 0f)).Length() > radius)
                    continue;

                IMaterial sphereMaterial = chooseMaterial switch
                {
                    < 0.8f  => new Lambertian(VectorUtils.Random() * VectorUtils.Random()),
                    < 0.95f => new Metal(VectorUtils.Random(0.5f, 1f), Global.RandomFloat() / 2f),
                    _       => new Dielectric(1.5f)
                };

                spheres.Add(new Sphere(center, sphereRadius, sphereMaterial));
            }

            return spheres;
        }
    }
}