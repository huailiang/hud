// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'


Shader "Unlit/VertxFragShader"
{
    Properties
    {
    	_Color ("Main Color", Color) = (1,1,1,1)  
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"

            fixed4 _Color;  

            struct appdata
            {
                float4 vertex : POSITION;
                fixed4 color : COLOR;
            };

            struct v2f
            {
                fixed4 vertexColor : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.vertexColor = v.color;
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
            	fixed4 c = i.vertexColor;
            	return c * _Color;
            }
            ENDCG
        }
    }
}

