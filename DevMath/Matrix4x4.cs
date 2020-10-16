using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
	public class Matrix4x4
	{
		//public float[][] m = new float[4][] { new float[4], new float[4], new float[4], new float[4] };
		public float[,] m = new float[4, 4];

		public Matrix4x4()
		{

		}

		public static Matrix4x4 Identity
		{
			get
			{
				Matrix4x4 m4 = new Matrix4x4();
				m4.m[0, 0] = 1f;
				m4.m[1, 1] = 1f;
				m4.m[2, 2] = 1f;
				m4.m[3, 3] = 1f;
				return m4;
			}
		}

		public float Determinant
		{
			get { throw new NotImplementedException(); }
		}

		public Matrix4x4 Inverse
		{
			get { throw new NotImplementedException(); }
		}

		public static Matrix4x4 Translate(Vector3 translation)
		{
			throw new NotImplementedException();
		}

		public static Matrix4x4 Rotate(Vector3 rotation)
		{
			//Er zijn 2 manieren om deze te berekenen
			throw new NotImplementedException();
		}

		public static Matrix4x4 RotateX(float rotation)
		{
			throw new NotImplementedException();
		}

		public static Matrix4x4 RotateY(float rotation)
		{
			throw new NotImplementedException();
		}

		public static Matrix4x4 RotateZ(float rotation)
		{
			throw new NotImplementedException();
		}

		public static Matrix4x4 Scale(Vector3 scale)
		{
			Matrix4x4 m4 = new Matrix4x4();
			m4.m[0, 0] = scale.x;
			m4.m[1, 2] = scale.y;
			m4.m[2, 3] = scale.z;
			return m4;
		}

		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			Matrix4x4 m4 = new Matrix4x4();

			m4.m[0, 0] = (lhs.m[0, 0] * rhs.m[0, 0]) + (lhs.m[1, 0] * rhs.m[0, 1]) + (lhs.m[2, 0] * rhs.m[0, 2]) + (lhs.m[3, 0] * rhs.m[0, 3]);
			m4.m[0, 0] = (lhs.m[0, 0] * rhs.m[1, 0]) + (lhs.m[1, 0] * rhs.m[1, 1]) + (lhs.m[2, 0] * rhs.m[1, 2]) + (lhs.m[3, 0] * rhs.m[1, 3]);
			m4.m[0, 0] = (lhs.m[0, 0] * rhs.m[2, 0]) + (lhs.m[1, 0] * rhs.m[2, 1]) + (lhs.m[2, 0] * rhs.m[2, 2]) + (lhs.m[3, 0] * rhs.m[2, 3]);
			m4.m[0, 0] = (lhs.m[0, 0] * rhs.m[3, 0]) + (lhs.m[1, 0] * rhs.m[3, 1]) + (lhs.m[2, 0] * rhs.m[3, 2]) + (lhs.m[3, 0] * rhs.m[3, 3]);

			m4.m[0, 0] = (lhs.m[0, 1] * rhs.m[0, 0]) + (lhs.m[1, 1] * rhs.m[0, 1]) + (lhs.m[2, 1] * rhs.m[0, 2]) + (lhs.m[3, 1] * rhs.m[0, 3]);
			m4.m[0, 0] = (lhs.m[0, 1] * rhs.m[1, 0]) + (lhs.m[1, 1] * rhs.m[1, 1]) + (lhs.m[2, 1] * rhs.m[1, 2]) + (lhs.m[3, 1] * rhs.m[1, 3]);
			m4.m[0, 0] = (lhs.m[0, 1] * rhs.m[2, 0]) + (lhs.m[1, 1] * rhs.m[2, 1]) + (lhs.m[2, 1] * rhs.m[2, 2]) + (lhs.m[3, 1] * rhs.m[2, 3]);
			m4.m[0, 0] = (lhs.m[0, 1] * rhs.m[3, 0]) + (lhs.m[1, 1] * rhs.m[3, 1]) + (lhs.m[2, 1] * rhs.m[3, 2]) + (lhs.m[3, 1] * rhs.m[3, 3]);

			m4.m[0, 0] = (lhs.m[0, 2] * rhs.m[0, 0]) + (lhs.m[1, 2] * rhs.m[0, 1]) + (lhs.m[2, 2] * rhs.m[0, 2]) + (lhs.m[3, 2] * rhs.m[0, 3]);
			m4.m[0, 0] = (lhs.m[0, 2] * rhs.m[1, 0]) + (lhs.m[1, 2] * rhs.m[1, 1]) + (lhs.m[2, 2] * rhs.m[1, 2]) + (lhs.m[3, 2] * rhs.m[1, 3]);
			m4.m[0, 0] = (lhs.m[0, 2] * rhs.m[2, 0]) + (lhs.m[1, 2] * rhs.m[2, 1]) + (lhs.m[2, 2] * rhs.m[2, 2]) + (lhs.m[3, 2] * rhs.m[2, 3]);
			m4.m[0, 0] = (lhs.m[0, 2] * rhs.m[3, 0]) + (lhs.m[1, 2] * rhs.m[3, 1]) + (lhs.m[2, 2] * rhs.m[3, 2]) + (lhs.m[3, 2] * rhs.m[3, 3]);

			m4.m[0, 0] = (lhs.m[0, 3] * rhs.m[0, 0]) + (lhs.m[1, 3] * rhs.m[0, 1]) + (lhs.m[2, 3] * rhs.m[0, 2]) + (lhs.m[3, 3] * rhs.m[0, 3]);
			m4.m[0, 0] = (lhs.m[0, 3] * rhs.m[1, 0]) + (lhs.m[1, 3] * rhs.m[1, 1]) + (lhs.m[2, 3] * rhs.m[1, 2]) + (lhs.m[3, 3] * rhs.m[1, 3]);
			m4.m[0, 0] = (lhs.m[0, 3] * rhs.m[2, 0]) + (lhs.m[1, 3] * rhs.m[2, 1]) + (lhs.m[2, 3] * rhs.m[2, 2]) + (lhs.m[3, 3] * rhs.m[2, 3]);
			m4.m[0, 0] = (lhs.m[0, 3] * rhs.m[3, 0]) + (lhs.m[1, 3] * rhs.m[3, 1]) + (lhs.m[2, 3] * rhs.m[3, 2]) + (lhs.m[3, 3] * rhs.m[3, 3]);

			return m4;
		}

		public static Vector4 operator *(Matrix4x4 lhs, Vector4 rhs)
		{
			throw new NotImplementedException();
		}
	}
}
