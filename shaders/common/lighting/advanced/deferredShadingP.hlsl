//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

#include "../../shaderModelAutoGen.hlsl"
#include "../../postfx/postFx.hlsl"
#include "shaders/common/torque.hlsl"

TORQUE_UNIFORM_SAMPLER2D(colorBufferTex,0);
TORQUE_UNIFORM_SAMPLER2D(directLightingBuffer,1);
TORQUE_UNIFORM_SAMPLER2D(matInfoTex,2);
TORQUE_UNIFORM_SAMPLER2D(indirectLightingBuffer,3);
TORQUE_UNIFORM_SAMPLER2D(prepassTex,4);

float4 main( PFXVertToPix IN) : TORQUE_TARGET0
{        
   float depth = TORQUE_PREPASS_UNCONDITION( prepassTex, IN.uv0 ).w;
   if (depth>0.9999)
      return float4(0,0,0,0);
	  
   float4 directLighting = TORQUE_TEX2D( directLightingBuffer, IN.uv0 ); //shadowmap*specular
   float3 colorBuffer = TORQUE_TEX2D( colorBufferTex, IN.uv0 ).rgb; //albedo
   float3 indirectLighting = TORQUE_TEX2D( indirectLightingBuffer, IN.uv0 ).rgb; //environment mapping*lightmaps
   float metalness = TORQUE_TEX2D( matInfoTex, IN.uv0 ).a; //flags|smoothness|ao|metallic
	  
   float frez = max(0.04,directLighting.a);
   
   float3 diffuseColor = colorBuffer - (colorBuffer * metalness);
   float3 fresnelColor = frez*(lerp(0.04f, colorBuffer, metalness)+indirectLighting);
   float3 reflectColor = indirectLighting*colorBuffer*metalness;
   colorBuffer = diffuseColor+reflectColor+fresnelColor;
   colorBuffer *= directLighting.rgb;
   
   return hdrEncode( float4(colorBuffer, 1.0) );
}
