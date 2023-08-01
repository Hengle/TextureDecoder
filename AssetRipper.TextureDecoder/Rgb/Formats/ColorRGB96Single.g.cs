//This code is source generated. Do not edit manually.

using AssetRipper.TextureDecoder.Attributes;

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	[RgbaAttribute(RedChannel = true, GreenChannel = true, BlueChannel = true, AlphaChannel = false, FullyUtilizedChannels = true)]
	public partial struct ColorRGB96Single : IColor<float>
	{
		public float R { get; set; }
		
		public float G { get; set; }
		
		public float B { get; set; }
		
		public readonly float A 
		{
			get => 1f;
			set { }
		}
		
		public readonly void GetChannels(out float r, out float g, out float b, out float a)
		{
			r = R;
			g = G;
			b = B;
			a = A;
		}
		
		public void SetChannels(float r, float g, float b, float a)
		{
			R = r;
			G = g;
			B = b;
		}
		
		static bool IColor<float>.HasRedChannel => true;
		static bool IColor<float>.HasGreenChannel => true;
		static bool IColor<float>.HasBlueChannel => true;
		static bool IColor<float>.HasAlphaChannel => false;
	}
}
