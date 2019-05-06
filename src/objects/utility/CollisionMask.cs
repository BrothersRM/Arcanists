using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Arcanists
{
    public interface ICollisionMask
    {

    }

    public class SquareCollisionMask : ICollisionMask
    {
        Rectangle Mask {get;set;}
    }

    public class CircleCollisionMask : ICollisionMask
    {
        
    }
}