using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Diagnostics;
using System.Windows.Media.Animation;
namespace Senior_Project
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        //Path to the model file
        private const string MODEL_PATH = "cube.stl";
        private int degree = 0;
        private Point3D currentPosition;
        MeshGeometryVisual3D obj = new MeshGeometryVisual3D();
        PerspectiveCamera myPCamera = new PerspectiveCamera();

        public UserControl1()
        {
            InitializeComponent();

            //Initialize the STL object
            obj.Content = Display3d(MODEL_PATH);
            viewPort3d.Children.Add(obj);

            //Lines for X/Y/Z Axis
            addLines();

            //Get the center point for the object
            //Note: The center origin point must be calculated for EVERY transformation.
            //Transformations are all relative to the center origin point, regardless of where the object "appears" in 3D space.
            var centerPoint = getCenter();
            currentPosition = centerPoint;

            //Declare the starting position for the object, then translate it to that position
            Point3D startPos = new Point3D(100, 100, 0);
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
        private Model3D Display3d(string model)
        {
            Model3D device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                ModelImporter import = new ModelImporter();

                //Load the 3D model file
                device = import.Load(model);
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
            if (e.Key == Key.W || e.Key == Key.S)
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
            if (e.Key == Key.V || e.Key == Key.C)
            {
                if (e.Key == Key.C)
                {
                    degree += 5;
                    if (degree == 360)
                    {
                        degree = 0;
                    }
                }
                else
                {
                    if (degree == 0)
                    {
                        degree = 360;
                    }
                    degree -= 5;
                }
                Console.WriteLine("Rotate axis is " + degree);

                var centerPoint = getCenter();

                //Use transform group to maintain status of previous translations, then execute rotation
                Transform3DGroup trans3Dgroup = new Transform3DGroup();
                TranslateTransform3D trans = new TranslateTransform3D(currentPosition.X - centerPoint.X, currentPosition.Y - centerPoint.Y, currentPosition.Z - centerPoint.Z);
                RotateTransform3D rot = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 0, 1), degree), currentPosition);
                trans3Dgroup.Children.Add(trans);
                trans3Dgroup.Children.Add(rot);

                obj.Transform = trans3Dgroup;
                myPCamera.LookDirection = new Vector3D(currentPosition.X - myPCamera.Position.X, currentPosition.Y - myPCamera.Position.Y, currentPosition.Z - myPCamera.Position.Z);
            }
        }

        private void addLines()
        {
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
        }

        private Point3D getCenter()
        {
            Model3D device2 = obj.Content;
            var bounds = device2.Bounds;
            var x = bounds.X + (bounds.SizeX / 2);
            var y = bounds.Y + (bounds.SizeY / 2);
            var z = bounds.Z + (bounds.SizeZ / 2);
            Point3D result = new Point3D(x, y, z);
            return result;
        }
    }
}
