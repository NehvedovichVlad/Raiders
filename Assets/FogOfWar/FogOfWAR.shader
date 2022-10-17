Shader "Custom/FogOfWAR"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" = "RenderType"= "Transparent" "LightMode" = "ForwardBase" }
        Blend SrcAlpha OneMinusSrcAlpha
        Lighting Off
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows
        fixed4 LightingNoLighting(SurfaceOutput s, fixed3 lightDir, float aten){
            fixed4 color;
            color.rgb = s.Albedo;
            color.a = s.Alpha;
            return color;
        }

        fixed4 _Color'
        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {

            half4 baseColor = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb * baseColor.b;
            o.Metallic = _Metallic;
            o.Alpha = _Color.a = baseColor.g;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
