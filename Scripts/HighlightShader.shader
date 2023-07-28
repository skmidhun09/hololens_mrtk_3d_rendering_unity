Shader "Custom/HighlightShader"
{
    Properties
    {
        _MainTex("Base Texture", 2D) = "white" {}
        _Color("Color", Color) = (1, 1, 1, 1)
        _HighlightRegion("Highlight Region", Range(0, 1)) = 0.5
    }

        SubShader
        {
            Tags { "RenderType" = "Opaque" }

            Pass
            {
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"

                struct appdata
                {
                    float4 vertex : POSITION;
                    float2 uv : TEXCOORD0;
                };

                struct v2f
                {
                    float2 uv : TEXCOORD0;
                    float4 vertex : SV_POSITION;
                };

                sampler2D _MainTex;
                float4 _Color;
                float _HighlightRegion;

                v2f vert(appdata v)
                {
                    v2f o;
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = v.uv;
                    return o;
                }

                fixed4 frag(v2f i) : SV_Target
                {
                    fixed4 c = tex2D(_MainTex, i.uv);
                    float distance = abs(i.uv.x - _HighlightRegion);
                    float highlight = smoothstep(0.45, 0.5, distance);
                    fixed4 highlightColor = fixed4(1, 1, 0, 1); // Customize highlight color here
                    return lerp(c * _Color, highlightColor, highlight);
                }
                ENDCG
            }
        }

            FallBack "Diffuse"
}
