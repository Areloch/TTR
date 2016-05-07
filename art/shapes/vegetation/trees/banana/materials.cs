//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(bananatree_material)
{
   diffuseMap[0] = "art/shapes/vegetation/trees/banana/bananatree_diffuse.dds";
   normalMap[0] = "art/shapes/vegetation/trees/banana/bananatree_normal.dds";
   mapTo = "bananatree";

   pixelSpecular = 0;
   specular = "0.988235 0.988235 0.976471 1";
   specularPower = 1;
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 107;
   
   // NOTE: This would be nice to have!
   backlight = 1;
   backLightFactor = "0.9 1.0 0.2";

   forestWindEnabled = 1;   
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/trees/banana/bananatree_specular.dds";

};


//--- bananatree_mature.DAE MATERIALS BEGIN ---

//--- bananatree_mature.DAE MATERIALS END ---


singleton Material(bananatree_mature_ColorEffectR87G225B198_material)
{
   mapTo = "ColorEffectR87G225B198-material";
   diffuseColor[0] = "0.341177 0.882353 0.776471 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(bananatree_mature_bananatree)
{
   mapTo = "bananatree";
   diffuseMap[0] = "bananatree_diffuse";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};
