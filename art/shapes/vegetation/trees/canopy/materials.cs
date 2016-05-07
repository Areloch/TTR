//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------



//CANOPY TREE: UNIVERSAL BARK

singleton Material(canopytree_bark_lodhi_material)
{
	mapTo = "canopytree_bark_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_diffuse.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";

   forestWindEnabled = 1;
   detailNormalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_detail_normal.dds";
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_barkflat_lodhi_material)
{
	mapTo = "canopytree_barkflat_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_diffuse.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";

   forestWindEnabled = 1;
   detailNormalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_detail_normal.dds";
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   detailScale[0] = "6 6";
   detailNormalMapStrength[0] = "1.5";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};


//CANOPY TREE: UNIVERSAL EXTRAS

singleton Material(canopytree_extras_lodhi_material)
{
	mapTo = "canopytree_extras_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 49;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "26";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};


//CANOPY TREE: NORMAL FOLIAGE

singleton Material(canopytree_fronds_lodhi_material)
{
	mapTo = "canopytree_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_lodlo_material)
{
	mapTo = "canopytree_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};




//CANOPY TREE: LIGHT FOLIAGE

singleton Material(canopytree_light_fronds_lodhi_material)
{
	mapTo = "canopytree_light_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_light_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_light_lodlo_material)
{
	mapTo = "canopytree_light_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_light_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};




//CANOPY TREE: DARK FOLIAGE

singleton Material(canopytree_dark_fronds_lodhi_material)
{
	mapTo = "canopytree_dark_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_dark_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_dark_lodlo_material)
{
	mapTo = "canopytree_dark_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_dark_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};







//--- canopytree_two.DAE MATERIALS BEGIN ---

//--- canopytree_two.DAE MATERIALS END ---

//--- canopytree_one_novines.DAE MATERIALS BEGIN ---

//--- canopytree_one_novines.DAE MATERIALS END ---

//--- canopytree_three.DAE MATERIALS BEGIN ---


//--- canopytree_three.DAE MATERIALS END ---

//--- shrub_one.DAE MATERIALS BEGIN ---


//--- shrub_one.DAE MATERIALS END ---


singleton Material(canopytree_one_novines_canopytree_bark_lodhi)
{
   mapTo = "canopytree_bark_lodhi";
   diffuseMap[0] = "canopytree_bark_diffuse";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(canopytree_one_novines_canopytree_extras_lodhi)
{
   mapTo = "canopytree_extras_lodhi";
   diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(canopytree_one_novines_canopytree_lodlo)
{
   mapTo = "canopytree_lodlo";
   diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "114";
};

singleton Material(canopytree_one_novines_ColorEffectR153G228B153_material)
{
   mapTo = "ColorEffectR153G228B153-material";
   diffuseColor[0] = "0.6 0.894118 0.6 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(canopytree_one_novines_canopytree_fronds_lodhi)
{
   mapTo = "canopytree_fronds_lodhi";
   diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "194";
   doubleSided = "1";
};

singleton Material(canopytree_two_canopytree_dark_fronds_lodhi)
{
   mapTo = "canopytree_dark_fronds_lodhi";
   diffuseMap[0] = "canopytree_fronds_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucent = "1";
};

singleton Material(canopytree_two_canopytree_dark_lodlo)
{
   mapTo = "canopytree_dark_lodlo";
   diffuseMap[0] = "canopytree_diffuse_transparency";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucent = "1";
};

singleton Material(canopytree_two_ColorEffectR225G88B199_material)
{
   mapTo = "ColorEffectR225G88B199-material";
   diffuseColor[0] = "0.882353 0.345098 0.780392 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(canopytree_two_canopytree_barkflat_lodhi)
{
   mapTo = "canopytree_barkflat_lodhi";
   diffuseMap[0] = "canopytree_bark_diffuse";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(canopytree_three_ColorEffectR166G229B229_material)
{
   mapTo = "ColorEffectR166G229B229-material";
   diffuseColor[0] = "0.65098 0.898039 0.898039 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(canopytree_three_ColorEffectR135G6B6_material)
{
   mapTo = "ColorEffectR135G6B6-material";
   diffuseColor[0] = "0.529412 0.0235294 0.0235294 1";
   smoothness[0] = "1";
   metalness[0] = "10";
   translucentBlendOp = "None";
};
