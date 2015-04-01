using UnityEngine;
using System.Collections;

public class HeightGenerator
{
	private int size = 250;
	private byte[,] biomeGenerator(byte[,] temperature,byte[,] humidity)
	{
		byte[,] l_biome = new byte[250,250];
		return l_biome;
	}

	private byte[,] temperatureGenerator(int size)
	{
		byte[,] l_temperature = new byte[size,size];
		return l_temperature;
	}

	private byte[,] humidityGenerator(byte[,] l_humidityBord)
	{
		byte[,] l_humidity = l_humidityBord;
		for(int i=0;i<l_humidity.Length;i++)
		{
			for(int p=0;p<l_humidity.Length;p++)
			{
				if(l_humidity[i,p] == 0)
				{
					int l_someHeight()
				}
			}
		}
		return l_humidity;
	}
}
