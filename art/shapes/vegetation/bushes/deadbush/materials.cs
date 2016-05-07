//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(deadbush)
{
   diffuseMap[0] = "art/shapes/vegetation/bushes/deadbush/deadbush_diffuse_transparency.dds";
   normalMap[0] = "art/shapes/vegetation/bushes/deadbush/deadbush_normals.dds";
   mapTo = "deadbush";
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 84;

   materialTag0 = "Vegetation";
   specularPower[0] = "54";
   pixelSpecular[0] = "0";
   specularMap[0] = "art/shapes/vegetation/smallplants/darkleafbush/darkleafbush_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   

};

