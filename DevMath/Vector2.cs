using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
	public struct Vector2
	{
		public float x;
		public float y;

		public float Magnitude
		{
			get { return (float)Math.Sqrt(x * x + y * y); }
		}

		public Vector2 Normalized
		{
			get { return new Vector2(x, y) / Magnitude; }
		}

		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return (lhs.x * rhs.x) + (lhs.y * rhs.y);
		}

		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			return a + (b - a) * t;
		}

		public static float Angle(Vector2 lhs, Vector2 rhs)
		{
			Vector2 delta = new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);

			double angleRadians = Math.Atan2(delta.y, delta.x);

			double angleDegrees = angleRadians * DevMath.RadToDeg((float)angleRadians);

			return (float)angleDegrees;
		}

		public static Vector2 DirectionFromAngle(float angle)
		{
			//Vector2 north = new Vector2(0, -1);
			//double radians = angle / 180 * Math.PI;
			throw new NotImplementedException();
		}

		public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
		}

		public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
		}

		public static Vector2 operator -(Vector2 v)
		{
			return new Vector2(-v.x, -v.y);
		}

		public static Vector2 operator *(Vector2 lhs, float scalar)
		{
			return new Vector2(lhs.x * scalar, lhs.y * scalar);
		}

		public static Vector2 operator /(Vector2 lhs, float scalar)
		{
			return new Vector2(lhs.x / scalar, lhs.y / scalar);
		}
	}
}
