
struct VertexShaderInput
{
	float3 Position : POSITION;
	float2 Normal : NORMAL;
	float2 ParamFormValue : TEXCOORD0;
	float SegmentType : TEXCOORD1;
};

struct PixelShaderInput
{
	float4 Position : POSITION;
	float3 NormalAndThickness : TEXCOORD0;
	float4 Color : COLOR;
	float2 ParamFormValue : TEXCOORD1;
	int SegmentType : TEXCOORD2;
};