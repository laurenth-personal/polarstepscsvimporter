Scripted importer for Unity to import coordinates CSV exported from Polarsteps.
This importer converts lattitude longitude coordinates into positions on a sphere of radius 1.
The component Coord List to Pos copies these positions into a LineRenderer component positions in order to visualize the successive positions as a trajectory.

### How to use

- Open the project in unity
- Export your coordinates from polarsteps in csv format
- Change the file extension of your .csv to .coord
- import the file in the unity project
- In the TestCoordinates scene locate the Sphere+Line gameObject
- In the Coord List to Pos component, replace the asset in coordinates with your own imported coordinates
-> The line renderer positions should update with your own coordinates. You can replace the sphere with an earth model to visualize your trip better.

  ### Tip
  You can use the Line Renderer's simplify function with a very low tolerance (around 0.0005) to remove noise in your trajectory.
