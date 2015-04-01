using UnityEngine;
using System.Collections;

public class HeightMapGenerator
{
	public Texture planetHeightMap(int res)
	{
		return new Texture();
	}

	private Texture generateHeightMap(int res)
	{
		return new Texture();
	}

	private float[,] applyDiamond(float[,] square)
	{
		float[,] l_fourSquareReturn = new float[4,4];

		// Define the corner of the square
		float l_ul = square[0,0];
		float l_ur = square[0,1];
		float l_bl = square[1,0];
		float l_br = square[1,1];

		// Add the old corners to the new squares
		l_fourSquareReturn[0,0] = l_ul;
		l_fourSquareReturn[0,2] = l_ur;
		l_fourSquareReturn[2,0] =l_bl;
		l_fourSquareReturn[2,2] = l_br;

		//Calculate the other points of the squares
		float l_um = (l_ul+l_ur)/2.0f;
		float l_lm = (l_ul+l_bl)/2.0f;
		float l_rm = (l_ur+l_br)/2.0f;
		float l_bm = (l_bl+l_br)/2.0f;
		float l_m =(l_ul+l_ur+l_bl+l_br)/4.0f;

		// Add the new corners to the new squares
		l_fourSquareReturn[0,1] = l_um;
		l_fourSquareReturn[1,0] = l_lm;
		l_fourSquareReturn[1,1] = l_m;
		l_fourSquareReturn[1,2] = l_rm;
		l_fourSquareReturn[2,1] = l_bm;

		// Return the 4 new squares
		return l_fourSquareReturn;
	}
}
