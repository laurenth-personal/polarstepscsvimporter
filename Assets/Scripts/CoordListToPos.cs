using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class CoordListToPos : MonoBehaviour
{
    public CoordinatesList coordinates;

    // Set positions array when the component's public members change
    private void OnValidate()
    {
        var renderer = this.GetComponent<LineRenderer>();
        if(coordinates != null && renderer != null)
        {
            List<Vector3> coordsList = coordinates.coordinateslist.ToList<Vector3>();

            //Order chronoligically
            var chronologicalCoords = coordsList.OrderBy(v => v.z);

            Vector3[] positions = new Vector3[coordinates.coordinateslist.Length];
            var coordsArray = chronologicalCoords.ToArray();
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = LatlongToDir(coordsArray[i]);
            }
            renderer.positionCount = positions.Length;
            renderer.SetPositions(positions);
        }        
    }

    //Convert lattitude longitude to vector 3 direction
    Vector3 LatlongToDir(Vector3 latlong)
    {
        Vector3 pos = new Vector3(Mathf.Cos(latlong.y * Mathf.Deg2Rad) * Mathf.Cos(latlong.x * Mathf.Deg2Rad), Mathf.Sin(latlong.x * Mathf.Deg2Rad), Mathf.Sin(latlong.y * Mathf.Deg2Rad) * Mathf.Cos(latlong.x * Mathf.Deg2Rad));
        return pos;
    }
}
