using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
	public class Circle
	{
		public Vector2 Position
		{
			get; set;
		}

		public float Radius
		{
			get; set;
		}

		public bool CollidesWith(Circle circle)
		{
			float diffx = this.Position.x - circle.Position.x;
			float diffy = this.Position.y - circle.Position.y;
			double distance = Math.Sqrt(diffx * diffx + diffy * diffy);

			if(distance < Radius + circle.Radius)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
