using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
	public class DevMath
	{
		public static float Lerp(float a, float b, float t)
		{
			throw new NotImplementedException();
		}

		public static float DistanceTraveled(float startVelocity, float acceleration, float time)
		{
			throw new NotImplementedException();
		}

		public static float Clamp(float value, float min, float max)
		{
			throw new NotImplementedException();
		}

		public static float RadToDeg(float angle)
		{
			return (float)(angle * 180 / Math.PI);
		}

		public static float DegToRad(float angle)
		{
			return (float)(angle * Math.PI / 180);
		}
	}
}
