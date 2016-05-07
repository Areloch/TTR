//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton TSShapeConstructor(Seaweed_01DAE)
{
   baseShape = "./seaweed_01.DAE";
};

function Seaweed_01DAE::onLoad(%this)
{
   %this.addImposter("25", "4", "1", "0", "128", "0", "75");
}
