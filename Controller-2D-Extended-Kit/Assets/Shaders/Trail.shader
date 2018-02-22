Shader "Custom/Trail" {
		Category{
			Tags{"Queue"="Transparent" "RenderType"="Transparent"}
			Blend SrcAlpha One
			ZWrite On
			ZTest Less

			Subshader{
			Pass{
			}
		}
	}
}
