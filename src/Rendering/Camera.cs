using System;
using System.Numerics;

namespace Raytracer.Rendering
{
    public class Camera
    {
        private readonly Vector3 _origin;
        private readonly Vector3 _corner;
        private readonly Vector3 _horizontal;
        private readonly Vector3 _vertical;
        private readonly Vector3 _w;
        private readonly Vector3 _u;
        private readonly Vector3 _v;
        private readonly float _lensRadius;

        public Camera(Vector3 lookFrom, Vector3 lookAt, Vector3 up, float verticalFov, float aspectRatio,
            float aperture, float focalDistance)
        {
            float theta = verticalFov * MathF.PI / 180f;
            float viewportHeight = 2f * MathF.Tan(theta / 2f);
            float viewportWidth = viewportHeight * aspectRatio;

            _w = (lookFrom - lookAt).Normalized();
            _u = up.Cross(_w).Normalized();
            _v = _w.Cross(_u);

            _origin = lookFrom;
            _horizontal = _u * (viewportWidth * focalDistance);
            _vertical = _v * (viewportHeight * focalDistance);
            _corner = _origin - _horizontal / 2f - _vertical / 2f - _w * focalDistance;
            _lensRadius = aperture / 2f;
        }

        public Ray GetRay(float start, float end)
        {
            Vector3 radius = VectorUtils.RandomInUnitCircle() * _lensRadius;
            Vector3 offset = _u * radius.X + _v * radius.Y;
            Vector3 direction = _corner + _horizontal * start + _vertical * end - _origin - offset;
            return new Ray(_origin + offset, direction);
        }
    }
}