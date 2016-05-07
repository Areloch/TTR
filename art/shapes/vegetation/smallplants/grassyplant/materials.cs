//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(grassyplant_material)
{
   mapTo = "grassyplant";

//   pixelSpecular = true;
//   specular = "1 1 0.75 0.25";
//   specularPower = 50;
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 75;
   
   forestWindEnabled = 1;   
   diffuseMap[0] = "art/shapes/vegetation/smallplants/grassyplant/grassyplant_diffuse_transparency.dds";
   normalMap[0] = "art/shapes/vegetation/smallplants/grassyplant/grassyplant_normals.dds";
   specularPower[0] = "26";
   pixelSpecular[0] = "0";
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/smallplants/grassyplant/grassyplant_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";

};

//--- grassyplant.DAE MATERIALS BEGIN ---
singleton Material(grassyplant_ColorEffectR229G166B215_material)
{
	mapTo = "ColorEffectR229G166B215-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.898039 0.65098 0.843137 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- grassyplant.DAE MATERIALS END ---

