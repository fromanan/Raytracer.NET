using System;

namespace Raytracer
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
        private readonly double _lensRadius;

        public Camera(Vector3 lookFrom, Vector3 lookAt, Vector3 vup, double verticalFov, double aspectRatio, double aperture,
            double focalDistance)
        {
            double theta = verticalFov * Math.PI / 180.0;
            double viewportHeight = 2.0 * Math.Tan(theta / 2.0);
            double viewportWidth = viewportHeight * aspectRatio;

            _w = lookFrom.Diff(lookAt).Normalized;
            _u = vup.Cross(_w).Normalized;
            _v = _w.Cross(_u);

            _origin = lookFrom;
            _horizontal = _u.Mult(viewportWidth * focalDistance);
            _vertical = _v.Mult(viewportHeight * focalDistance);
            _corner = _origin
                .Diff(_horizontal.Div(2.0))
                .Diff(_vertical.Div(2.0))
                .Diff(_w.Mult(focalDistance));

            _lensRadius = aperture / 2.0;
        }

        public Ray GetRay(double start, double end)
        {
            Vector3 radius = Vector3.RandomInUnitCircle().Mult(_lensRadius);
            Vector3 offset = _u
                .Mult(radius.X)
                .Sum(_v.Mult(radius.Y));
            Vector3 direction = _corner
                .Sum(_horizontal.Mult(start))
                .Sum(_vertical.Mult(end))
                .Diff(_origin)
                .Diff(offset);

            return new Ray(_origin.Sum(offset), direction);
        }
    }
}