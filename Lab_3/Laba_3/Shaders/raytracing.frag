#version 430

//tupie pidorasi kto pisal etu metodichku
//huli ia dolzen fixit ih kosiaki

/*** CONFIG CONSTANTS ***/

#define EPSILON = 0.001
#define BIG = 1000000.0
const int DIFFUSE = 1;
const int REFLECTION = 2;
const int REFRACTION = 3;

/*** DATA STRUCTURES ***/

struct SCamera
{
  vec3 Position;
  vec3 View;
  vec3 Up;
  vec3 Side;
  vec2 Scale;
};

struct SRay
{
  vec3 Origin;
  vec3 Direction;
};

struct SSphere
{
 vec3 Center;
 float Radius;
 int MaterialIdx;
};

struct STriangle
{
 vec3 v1;
 vec3 v2;
 vec3 v3;
 int MaterialIdx;
};

/*** SHADER INTERFACE ***/

out vec4 FragColor;
in vec3 glPosition;
STriangle triangles[10];
SSphere spheres[2];

/*** SUPPORT FUNCTIONS ***/

SRay GenerateRay ( SCamera uCamera )
{
  vec2 coords = glPosition.xy * uCamera.Scale;
  vec3 direction = uCamera.View + uCamera.Side * coords.x + uCamera.Up * coords.y;
  return SRay ( uCamera.Position, normalize(direction) );
}

SCamera initializeDefaultCamera()
{
  //** CAMERA **//
  SCamera camera;
  camera.Position = vec3(0.0, 0.0, -8.0);
  camera.View = vec3(0.0, 0.0, 1.0);
  camera.Up = vec3(0.0, 1.0, 0.0);
  camera.Side = vec3(1.0, 0.0, 0.0);
  camera.Scale = vec2(1.0);
  return camera;
}

void initializeDefaultScene(out STriangle triangles[10], out SSphere spheres[2])
{

  // ia ne vdupliay eti coordinati
  
  /** TRIANGLES **/
  /* left wall */
  triangles[0].v1 = vec3(-5.0,-5.0,-5.0);
  triangles[0].v2 = vec3(-5.0, 5.0, 5.0);
  triangles[0].v3 = vec3(-5.0, 5.0,-5.0);
  triangles[0].MaterialIdx = 0;
  
  triangles[1].v1 = vec3(-5.0,-5.0,-5.0);
  triangles[1].v2 = vec3(-5.0,-5.0, 5.0);
  triangles[1].v3 = vec3(-5.0, 5.0, 5.0);
  triangles[1].MaterialIdx = 0;
  
  /* back wall */
  triangles[2].v1 = vec3(-5.0,-5.0, 5.0);
  triangles[2].v2 = vec3( 5.0,-5.0, 5.0);
  triangles[2].v3 = vec3(-5.0, 5.0, 5.0);
  triangles[2].MaterialIdx = 0;
  
  triangles[3].v1 = vec3( 5.0, 5.0, 5.0);
  triangles[3].v2 = vec3(-5.0, 5.0, 5.0);
  triangles[3].v3 = vec3( 5.0,-5.0, 5.0);
  triangles[3].MaterialIdx = 0;
  
  /* ebani kub */
  // eto vrode nado delat no ia ne ponimaiy ih sistemu coordinat
  
  /** SPHERES **/
  spheres[0].Center = vec3(-1.0,-1.0,-2.0);
  spheres[0].Radius = 2.0;
  spheres[0].MaterialIdx = 0;
  
  spheres[1].Center = vec3(2.0,1.0,2.0);
  spheres[1].Radius = 1.0;
  spheres[1].MaterialIdx = 0;
}

void main ( void )
{
  //ia v shoke eto govno compilitsia bez oshibok
  
  initializeDefaultScene ( triangles, spheres );
  SCamera uCamera = initializeDefaultCamera();
  SRay ray = GenerateRay( uCamera);
  FragColor = vec4 ( abs(ray.Direction.xy), 0, 1.0);
}


