Scripted importer for Unity to import coordinates CSV exported from Polarsteps.
This importer converts lattitude longitude coordinates into positions on a sphere of radius 1.
The component Coord List to Pos copies these positions into a LineRenderer component positions in order to visualize the successive positions as a trajectory.

# How to use

- Open the project in unity
- Export your coordinates from polarsteps in csv format
- Change the file extension of your .csv to .coord
- import the file in the unity project
- In the TestCoordinates scene locate the Sphere+Line gameObject
- In the Coord List to Pos component, replace the asset in coordinates with your own imported coordinates
-> The line renderer positions should update with your own coordinates. You can replace the sphere with an earth model to visualize your trip better.

# Tips
- You can use the Line Renderer's simplify function with a very low tolerance (around 0.0005) to remove noise in your trajectory
- The line renderer width needs to be really small (0.005 or lower). You cando right click / edit key on the width curve in order to set the precise value you want

# Details
- The locations.coord is a sample coordinates file
- The scripts are in the Scripts folder
- The importer is in an editor folder, it will only work in unity editor
- The Coord List to Pos component can be removed once you're happy with the result as it will not be removed automatically from the build. it's only useful in the editor
