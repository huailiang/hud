Shader "Unlit/VertxColorShader"
{
	Properties
	{
		_Color ("Main Color", Color) = (1,1,1,1)  
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert vertex:vert
		fixed4 _Color;  

		struct Input
		{
			float4 vertexColor;
		};

		void vert(inout appdata_full v,out Input o)
		{
			UNITY_INITIALIZE_OUTPUT(Input,o);
			o.vertexColor=v.color;
		}

		void surf (Input IN, inout SurfaceOutput o) 
		{
			o.Albedo=IN.vertexColor * _Color;
		}
		ENDCG
	}
}
