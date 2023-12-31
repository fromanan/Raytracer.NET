﻿using System.Collections.Generic;
using System.Linq;

namespace Raytracer
{
    public class ObjectList : List<IObject>, IObject
    {
        public Hit Hit(Ray ray, double minimumDistance, double maximumDistance)
        {
            Hit nearestHit = new();
            
            double closest = maximumDistance;

            foreach (Hit? hit in this.Select(o => o.Hit(ray, minimumDistance, closest)).Where(hit => hit is { IsHit: true }))
            {
                closest = hit!.Nearest;
                nearestHit = hit;
            }

            return nearestHit;
        }
    }
}