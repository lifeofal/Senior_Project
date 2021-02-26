using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace _3DModel
{

    public partial class MainWindow : Window
    {
        //Path to the model file
        private const string MODEL_PATH = "owl.stl";
        private int degree = 0;
        private Point3D currentPosition;
        MeshGeometryVisual3D obj = new MeshGeometryVisual3D();
        MeshGeometry3D mesh = new MeshGeometry3D();
        PerspectiveCamera myPCamera = new PerspectiveCamera();
        Model3DGroup model = new Model3DGroup();
        public MainWindow()
        {
            InitializeComponent();
            //Initialize the STL object
  
            model = Display3d(MODEL_PATH);
            obj.MeshGeometry = (MeshGeometry3D)((GeometryModel3D)model.Children[0]).Geometry;
            viewPort3d.Children.Add(obj);

            //Lines for X/Y/Z Axisa
            addLines();

            //Get the center point for the object
            //Note: The center origin point must be calculated for EVERY transformation.
            //Transformations are all relative to the center origin point, regardless of where the object "appears" in 3D space.
            var centerPoint = getCenter();
            currentPosition = centerPoint;

            //Declare the starting position for the object, then translate it to that position
            double zHeight = obj.Content.Bounds.SizeZ / 2;
            Point3D startPos = new Point3D(100, 100, zHeight);
            TranslateTransform3D trans = new TranslateTransform3D();
            trans.OffsetX = (startPos.X - currentPosition.X);
            trans.OffsetY = (startPos.Y - currentPosition.Y);
            trans.OffsetZ = (startPos.Z - currentPosition.Z);
            obj.Transform = trans;
            currentPosition = startPos;

            Console.WriteLine("Center point starts at: " + centerPoint.X + " " + centerPoint.Y + " " + centerPoint.Z);
            Console.WriteLine("Camera starts at: " + myPCamera.Position.X + " " + myPCamera.Position.Y + " " + myPCamera.Position.Z);
           
            //Event handlers to allow for transformations using mouse clicks or keys
            //C key rotates the object left. V key rotates the object right.  
            //W key pushes the object away from the camera. S key pulls the object towards the camera.
            //A double click brings the object to the camera. 
            MouseDoubleClick += new MouseButtonEventHandler(mouseDoubleClick);
            viewPort3d.KeyDown += new KeyEventHandler(wPushsPull);
            viewPort3d.KeyDown += new KeyEventHandler(cvRotate);
            viewPort3d.KeyDown += new KeyEventHandler(writeDataHandle);

            // Defines the camera used to view the 3D object. In order to view the 3D object,
            // the camera must be positioned and pointed such that the object is within view
            // of the camera.
            // Specify where in the 3D scene the camera is.
            myPCamera.Position = new Point3D(300, 300, 300);

            // Specify the direction that the camera is pointing.
            myPCamera.LookDirection = new Vector3D(currentPosition.X - myPCamera.Position.X, currentPosition.Y - myPCamera.Position.Y, currentPosition.Z - myPCamera.Position.Z);

            // Define camera's horizontal field of view in degrees.
            myPCamera.FieldOfView = 60;
            // Specify the cameras "up" direction
            myPCamera.UpDirection = new Vector3D(0, 0, 1);
            viewPort3d.Camera = myPCamera;
        }
        /// <summary>
        /// Display 3D Model
        /// </summary>
        /// <param name="model">Path to the Model file</param>
        /// <returns>3D Model Content</returns>
        private Model3DGroup Display3d(string filePath)
        {
            Model3DGroup device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                StLReader read = new StLReader();

                //Load the 3D model file
                device = read.Read(filePath);
            }
            catch (Exception e)
            {
                // Handle exception in case can not file 3D model
                MessageBox.Show("Exception Error : " + e.StackTrace);
            }
            return device;
        }

        private void mouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Calculates a vector from origin to camera, then moves the object to the camera 
            Point pointToWindow = Mouse.GetPosition(this);
            Point pointToScreen = PointToScreen(pointToWindow);
            Console.WriteLine("Mouse position is " + pointToWindow.X + ", " + pointToWindow.Y);
        }

        private void wPushsPull(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.W || e.Key == Key.S)
            {
                //Get camera position, then use it to calculate the vector from camera to object current location
                Point3D camPoint = viewPort3d.Camera.Position;
                Vector3D camToCurrent = new Vector3D(currentPosition.X - camPoint.X, currentPosition.Y - camPoint.Y, currentPosition.Z - camPoint.Z);
                Console.WriteLine("Camera position is: " + camPoint.X + " " + camPoint.Y + " " + camPoint.Z);
                Console.WriteLine("Current position is: " + currentPosition.X + " " + currentPosition.Y + " " + currentPosition.Z);
                Console.WriteLine("The offset from Camera to Current is " + camToCurrent.X + " " + camToCurrent.Y + " " + camToCurrent.Z);

                //Get length of the camToCurrent vector. This length will be extended or reduced depending on which key was pressed.
                double camToCurrentLength = camToCurrent.Length;
                double camToGoalLength;
                if (e.Key == Key.W)
                {
                    camToGoalLength = camToCurrentLength + 10;
                }
                else
                {
                    camToGoalLength = camToCurrentLength - 10;
                }

                var centerPoint = getCenter();

                //Use the length of the goal vector to calculate the offset in each individual direction
                double xOffset;
                double yOffset;
                double zOffset;
                
                //Formula for new offset: sqrt((current_position*(goalVectorLength/currentVectorLength)^2)
                if (camToCurrent.X < 0)
                {
                    xOffset = -(Math.Sqrt((camToCurrent.X * (camToGoalLength / camToCurrentLength)) * (camToCurrent.X * (camToGoalLength / camToCurrentLength))));

                }
                else
                {
                    xOffset = Math.Sqrt((camToCurrent.X * (camToGoalLength / camToCurrentLength)) * (camToCurrent.X * (camToGoalLength / camToCurrentLength)));
                }
                if (camToCurrent.Y < 0)
                {
                    yOffset = -(Math.Sqrt((camToCurrent.Y * (camToGoalLength / camToCurrentLength)) * (camToCurrent.Y * (camToGoalLength / camToCurrentLength))));
                }
                else
                {
                    yOffset = Math.Sqrt((camToCurrent.Y * (camToGoalLength / camToCurrentLength)) * (camToCurrent.Y * (camToGoalLength / camToCurrentLength)));
                }
                if (camToCurrent.Z < 0)
                {
                    zOffset = -(Math.Sqrt((camToCurrent.Z * (camToGoalLength / camToCurrentLength)) * (camToCurrent.Z * (camToGoalLength / camToCurrentLength))));
                }
                else
                {
                    zOffset = Math.Sqrt((camToCurrent.Z * (camToGoalLength / camToCurrentLength)) * (camToCurrent.Z * (camToGoalLength / camToCurrentLength)));
                }

                Console.WriteLine("The offset from camera to goal is: " + xOffset + " " + yOffset + " " + zOffset);

                //Use the length of each individual direction to calculate the goal position
                double goalXPos = camPoint.X + xOffset;
                double goalYPos = camPoint.Y + yOffset;
                double goalZPos = camPoint.Z + zOffset;
                Console.WriteLine("Goal position is: " + goalXPos + " " + goalYPos + " " + goalZPos);

                Point3D goalPoint = new Point3D(goalXPos, goalYPos, goalZPos);
   
                //Create vector object using goal position and centerpoint for the translation
                Vector3D goalVector = new Vector3D(goalXPos - centerPoint.X, goalYPos - centerPoint.Y, goalZPos - centerPoint.Z);

                //Create transformation group - use to execute translation and also save previous rotation status 
                Transform3DGroup trans3dgroup = new Transform3DGroup();
                TranslateTransform3D trans = new TranslateTransform3D(goalVector.X, goalVector.Y, goalVector.Z);
                currentPosition.X = goalXPos;
                currentPosition.Y = goalYPos;
                currentPosition.Z = goalZPos;
                RotateTransform3D rot = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 0, -1), degree), currentPosition);
                trans3dgroup.Children.Add(trans);
                trans3dgroup.Children.Add(rot);
                obj.Transform = trans3dgroup;

                myPCamera.LookDirection = new Vector3D(currentPosition.X - myPCamera.Position.X, currentPosition.Y - myPCamera.Position.Y, currentPosition.Z - myPCamera.Position.Z);

            }
         }

        private void cvRotate(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.V || e.Key == Key.C)
            {
                if(e.Key == Key.C)
                {
                    degree += 5;
                    if(degree == 360)
                    {
                        degree = 0;
                    }
                }
                else
                {
                    if(degree == 0)
                    {
                        degree = 360;
                    }
                    degree -= 5;
                }
                Console.WriteLine("Rotate axis is "+ degree);

                var centerPoint = getCenter();

                //Use transform group to maintain status of previous translations, then execute rotation
                Transform3DGroup trans3Dgroup = new Transform3DGroup();
                TranslateTransform3D trans = new TranslateTransform3D(currentPosition.X - centerPoint.X, currentPosition.Y - centerPoint.Y, currentPosition.Z - centerPoint.Z);
                RotateTransform3D rot = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 0, 1), degree), currentPosition);
                trans3Dgroup.Children.Add(trans);
                trans3Dgroup.Children.Add(rot);

                obj.Transform = trans3Dgroup;
                Console.WriteLine(obj.Children.Count);
                myPCamera.LookDirection = new Vector3D(currentPosition.X - myPCamera.Position.X, currentPosition.Y - myPCamera.Position.Y, currentPosition.Z - myPCamera.Position.Z);
            }
        }

        private void addLines()
        {
            //Axis lines
            LinesVisual3D yLine = new LinesVisual3D();
            LinesVisual3D xLine = new LinesVisual3D();
            LinesVisual3D zLine = new LinesVisual3D();

            yLine.Color = Colors.Red;
            xLine.Color = Colors.Gold;
            zLine.Color = Colors.Black;

            Point3D center = new Point3D(0, 0, 0);
            Point3D yPoint = new Point3D(0, 200, 0);
            Point3D xPoint = new Point3D(200, 0, 0);
            Point3D zPoint = new Point3D(0, 0, 200);

            yLine.Points.Add(center);
            yLine.Points.Add(yPoint);
            xLine.Points.Add(center);
            xLine.Points.Add(xPoint);
            zLine.Points.Add(center);
            zLine.Points.Add(zPoint);

            viewPort3d.Children.Add(xLine);
            viewPort3d.Children.Add(yLine);
            viewPort3d.Children.Add(zLine);

            //Grid lines
            LinesVisual3D xLine2 = new LinesVisual3D();
            Point3D xPoint2 = new Point3D(20, 0, 0);
            Point3D xPoint3 = new Point3D(20, 200, 0);
            xLine2.Points.Add(xPoint2);
            xLine2.Points.Add(xPoint3);
            xLine2.Color = Colors.Black;
            viewPort3d.Children.Add(xLine2);

            LinesVisual3D xLine3 = new LinesVisual3D();
            Point3D xPoint4 = new Point3D(40, 0, 0);
            Point3D xPoint5 = new Point3D(40, 200, 0);
            xLine3.Points.Add(xPoint4);
            xLine3.Points.Add(xPoint5);
            xLine3.Color = Colors.Black;
            viewPort3d.Children.Add(xLine3);

            LinesVisual3D xLine4 = new LinesVisual3D();
            Point3D xPoint6 = new Point3D(60, 0, 0);
            Point3D xPoint7 = new Point3D(60, 200, 0);
            xLine4.Points.Add(xPoint6);
            xLine4.Points.Add(xPoint7);
            xLine4.Color = Colors.Black;
            viewPort3d.Children.Add(xLine4);

            LinesVisual3D xLine5 = new LinesVisual3D();
            Point3D xPoint8 = new Point3D(80, 0, 0);
            Point3D xPoint9 = new Point3D(80, 200, 0);
            xLine5.Points.Add(xPoint8);
            xLine5.Points.Add(xPoint9);
            xLine5.Color = Colors.Black;
            viewPort3d.Children.Add(xLine5);

            LinesVisual3D xLine6 = new LinesVisual3D();
            Point3D xPoint10 = new Point3D(100, 0, 0);
            Point3D xPoint11 = new Point3D(100, 200, 0);
            xLine6.Points.Add(xPoint10);
            xLine6.Points.Add(xPoint11);
            xLine6.Color = Colors.Black;
            viewPort3d.Children.Add(xLine6);

            LinesVisual3D xLine7 = new LinesVisual3D();
            Point3D xPoint12 = new Point3D(120, 0, 0);
            Point3D xPoint13 = new Point3D(120, 200, 0);
            xLine7.Points.Add(xPoint12);
            xLine7.Points.Add(xPoint13);
            xLine7.Color = Colors.Black;
            viewPort3d.Children.Add(xLine7);

            LinesVisual3D xLine8 = new LinesVisual3D();
            Point3D xPoint14 = new Point3D(140, 0, 0);
            Point3D xPoint15 = new Point3D(140, 200, 0);
            xLine8.Points.Add(xPoint14);
            xLine8.Points.Add(xPoint15);
            xLine8.Color = Colors.Black;
            viewPort3d.Children.Add(xLine8);

            LinesVisual3D xLine9 = new LinesVisual3D();
            Point3D xPoint16 = new Point3D(160, 0, 0);
            Point3D xPoint17 = new Point3D(160, 200, 0);
            xLine9.Points.Add(xPoint16);
            xLine9.Points.Add(xPoint17);
            xLine9.Color = Colors.Black;
            viewPort3d.Children.Add(xLine9);

            LinesVisual3D xLine10 = new LinesVisual3D();
            Point3D xPoint18 = new Point3D(180, 0, 0);
            Point3D xPoint19 = new Point3D(180, 200, 0);
            xLine10.Points.Add(xPoint18);
            xLine10.Points.Add(xPoint19);
            xLine10.Color = Colors.Black;
            viewPort3d.Children.Add(xLine10);

            LinesVisual3D xLine11 = new LinesVisual3D();
            Point3D xPoint20 = new Point3D(200, 0, 0);
            Point3D xPoint21 = new Point3D(200, 200, 0);
            xLine11.Points.Add(xPoint20);
            xLine11.Points.Add(xPoint21);
            xLine11.Color = Colors.Black;
            viewPort3d.Children.Add(xLine11);

            LinesVisual3D yLine2 = new LinesVisual3D();
            Point3D yPoint2 = new Point3D(0, 20, 0);
            Point3D yPoint3 = new Point3D(200, 20, 0);
            yLine2.Points.Add(yPoint2);
            yLine2.Points.Add(yPoint3);
            yLine2.Color = Colors.Black;
            viewPort3d.Children.Add(yLine2);
            
            LinesVisual3D yLine3 = new LinesVisual3D();
            Point3D yPoint4 = new Point3D(0, 40, 0);
            Point3D yPoint5 = new Point3D(200, 40, 0);
            yLine3.Points.Add(yPoint4);
            yLine3.Points.Add(yPoint5);
            yLine3.Color = Colors.Black;
            viewPort3d.Children.Add(yLine3);

            LinesVisual3D yLine4 = new LinesVisual3D();
            Point3D yPoint6 = new Point3D(0, 60, 0);
            Point3D yPoint7 = new Point3D(200, 60, 0);
            yLine4.Points.Add(yPoint6);
            yLine4.Points.Add(yPoint7);
            yLine4.Color = Colors.Black;
            viewPort3d.Children.Add(yLine4);

            LinesVisual3D yLine5 = new LinesVisual3D();
            Point3D yPoint8 = new Point3D(0, 80, 0);
            Point3D yPoint9 = new Point3D(200, 80, 0);
            yLine5.Points.Add(yPoint8);
            yLine5.Points.Add(yPoint9);
            yLine5.Color = Colors.Black;
            viewPort3d.Children.Add(yLine5);

            LinesVisual3D yLine6 = new LinesVisual3D();
            Point3D yPoint10 = new Point3D(0, 100, 0);
            Point3D yPoint11 = new Point3D(200, 100, 0);
            yLine6.Points.Add(yPoint10);
            yLine6.Points.Add(yPoint11);
            yLine6.Color = Colors.Black;
            viewPort3d.Children.Add(yLine6);

            LinesVisual3D yLine7 = new LinesVisual3D();
            Point3D yPoint12 = new Point3D(0, 120, 0);
            Point3D yPoint13 = new Point3D(200, 120, 0);
            yLine7.Points.Add(yPoint12);
            yLine7.Points.Add(yPoint13);
            yLine7.Color = Colors.Black;
            viewPort3d.Children.Add(yLine7);

            LinesVisual3D yLine8 = new LinesVisual3D();
            Point3D yPoint14 = new Point3D(0, 140, 0);
            Point3D yPoint15 = new Point3D(200, 140, 0);
            yLine8.Points.Add(yPoint14);
            yLine8.Points.Add(yPoint15);
            yLine8.Color = Colors.Black;
            viewPort3d.Children.Add(yLine8);

            LinesVisual3D yLine9 = new LinesVisual3D();
            Point3D yPoint16 = new Point3D(0, 160, 0);
            Point3D yPoint17 = new Point3D(200, 160, 0);
            yLine9.Points.Add(yPoint16);
            yLine9.Points.Add(yPoint17);
            yLine9.Color = Colors.Black;
            viewPort3d.Children.Add(yLine9);

            LinesVisual3D yLine10 = new LinesVisual3D();
            Point3D yPoint18 = new Point3D(0, 180, 0);
            Point3D yPoint19 = new Point3D(200, 180, 0);
            yLine10.Points.Add(yPoint18);
            yLine10.Points.Add(yPoint19);
            yLine10.Color = Colors.Black;
            viewPort3d.Children.Add(yLine10);

            LinesVisual3D yLine11 = new LinesVisual3D();
            Point3D yPoint20 = new Point3D(0, 200, 0);
            Point3D yPoint21 = new Point3D(200, 200, 0);
            yLine11.Points.Add(yPoint20);
            yLine11.Points.Add(yPoint21);
            yLine11.Color = Colors.Black;
            viewPort3d.Children.Add(yLine11);            
        }

        private Point3D getCenter()
        {
            Model3D device2 = obj.Content;
            var bounds = device2.Bounds;
            Console.WriteLine("Size in Z: " + bounds.SizeZ);
            var x = bounds.X + (bounds.SizeX / 2);
            var y = bounds.Y + (bounds.SizeY / 2);
            var z = bounds.Z + (bounds.SizeZ / 2);
            Point3D result = new Point3D(x, y, z);
            return result;
        }

        private void writeDataHandle(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Y)
            {
                writeData();
            }
        }
        private async Task writeData()
        {
            MeshGeometry3D mesh = (MeshGeometry3D)((GeometryModel3D)model.Children[0]).Geometry;
            Point3D[] _3dPoints = mesh.Positions.ToArray();
            int[] triangleIndex = mesh.TriangleIndices.ToArray();
            Point[] textureCoordinates = mesh.TextureCoordinates.ToArray();
            Vector3D[] normVectors = mesh.Normals.ToArray();
            Point3D tempPoint;
            Vector3D tempVec;
            StreamWriter file = new StreamWriter("ModelData.txt");
            for (int i = 0; i < _3dPoints.Length; i++)
            {
                tempPoint = obj.Transform.Transform(_3dPoints[i]);
                tempVec = obj.Transform.Transform(normVectors[i]);
                await file.WriteLineAsync("3D Point: " + tempPoint.X + " " + tempPoint.Y + " " + tempPoint.Z);
                //await file.WriteLineAsync("Triangle Index: " + triangleIndex[i]);
                //await file.WriteLineAsync("Texture Coordinate: " + textureCoordinates[i].X + " " + textureCoordinates[i].Y);
                await file.WriteLineAsync("Normal Vector: " + tempVec.X + " " + tempVec.Y + " " + tempVec.Z);
            }      
        }
    }
}