//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(fern_material)
{
   diffuseMap[0] = "art/shapes/vegetation/smallplants/fern/fern_diffuse_transparency.dds";
   normalMap[0] = "art/shapes/vegetation/smallplants/fern/fern_normal.dds";
   mapTo = "fern";

   pixelSpecular = 0;
   specular = "1 1 0.85 0.25";
   specularPower = 10;
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 84;

   forestWindEnabled = 1; 
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/smallplants/fern/fern_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};

