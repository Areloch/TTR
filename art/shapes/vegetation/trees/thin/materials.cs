//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(thintree_fronds_material)
{
   diffuseMap[0] = "art/shapes/vegetation/trees/thin/thintree_diffuse_transparency.dds";
   normalMap[0] = "art/shapes/vegetation/trees/thin/thintree_normal.dds";
   mapTo = "thintree_fronds";
     
   pixelSpecular = 0;
   specular = "1 1 0.65 0.25";
   specularPower = 1;

   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 84;

   forestWindEnabled = 1;   
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/trees/thin/thintree_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";

};

singleton Material(thintree_bark_material)
{
   diffuseMap[0] = "art/shapes/vegetation/trees/thin/thintree_bark_diffuse.dds";
   normalMap[0] = "art/shapes/vegetation/trees/thin/thintree_bark_normal.dds";
   mapTo = "thintree_bark";
     
   pixelSpecular = 0;
   specular = "1 1 0.65 0.25";
   specularPower = 50;

   forestWindEnabled = 1;   
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/trees/thin/thintree_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};

//--- thintree_one.DAE MATERIALS BEGIN ---
singleton Material(thintree_one_ColorEffectR177G27B88_material)
{
	mapTo = "ColorEffectR177G27B88-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.694118 0.105882 0.345098 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- thintree_one.DAE MATERIALS END ---


singleton Material(thintree_one_thintree_bark)
{
   mapTo = "thintree_bark";
   diffuseMap[0] = "thintree_bark_diffuse";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(thintree_one_ColorEffectR177G27B88_material)
{
   mapTo = "ColorEffectR177G27B88-material";
   diffuseColor[0] = "0.694118 0.105882 0.345098 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(thintree_one_thintree_fronds)
{
   mapTo = "thintree_fronds";
   diffuseMap[0] = "art/shapes/vegetation/trees/thin/thintree_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "73";
   doubleSided = "1";
};
