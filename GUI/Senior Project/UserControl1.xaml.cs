using System;
using System.IO;
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
        private double xOffset = 0;
        private double yOffset = 0;
        private double zOffset = 0;
        private int degreeX = 0;
        private int degreeY = 0;
        private int degreeZ = 0;
        Boolean xAxis = false;
        Boolean yAxis = false;
        Boolean zAxis = true;
        private Point3D currentPosition;
        MeshGeometryVisual3D obj = new MeshGeometryVisual3D();
        MeshGeometry3D mesh = new MeshGeometry3D();
        PerspectiveCamera myPCamera = new PerspectiveCamera();
        Model3DGroup model = new Model3DGroup();
        //The following two variables affect the table size. These should obtain their values from the config file. 
        double xMaxi = 300;
        double yMaxi = 300;
        double zMaxi = 200;
        double scaleX = 1;
        double scaleY = 1;
        double scaleZ = 1;
        double zLow;
        Point3D startPos;
        Point3D centerPoint;

        public UserControl1(String filepath)
        {
            InitializeComponent();

            
            //Initialize the STL object
            //obj.Content = Display3d(@"C:\Users\Johnathon\Desktop\DAF CF met trailer.STL");
            model = (Model3DGroup)Display3d(filepath);
            obj.MeshGeometry = (MeshGeometry3D)((GeometryModel3D)model.Children[0]).Geometry;
            viewPort3d.Children.Add(obj);

            //Get the value needed for z offset to move object onto the table
            zLow = getZLow();

            //Lines for X/Y/Z Axis
            addLines();

            //Get the center point for the object
            //Transformations are all relative to the center origin point, regardless of where the object "appears" in 3D space.
            centerPoint = getCenter();
            currentPosition = centerPoint;

            //Sets the starting position for the object
            set();

            //If the object is too large for the table, scale it down until it isn't. 
            scaleDown();
 
            // Defines the camera used to view the 3D object. In order to view the 3D object,
            // the camera must be positioned and pointed such that the object is within view
            // of the camera.
            // Specify where in the 3D scene the camera is.
            myPCamera.Position = new Point3D(xMaxi/2, -200, 300);

            // Specify the direction that the camera is pointing.
            myPCamera.LookDirection = new Vector3D(currentPosition.X - myPCamera.Position.X, currentPosition.Y - myPCamera.Position.Y, currentPosition.Z - myPCamera.Position.Z);

            // Define camera's horizontal field of view in degrees.
            myPCamera.FieldOfView = 60;
            // Specify the cameras "up" direction
            myPCamera.UpDirection = new Vector3D(0, 0, 1);
            viewPort3d.Camera = myPCamera;

        }


        public void changeSTLModel(String filename)
        {
            viewPort3d.Children.Add(obj);
            MeshGeometryVisual3D newObj = new MeshGeometryVisual3D();
            newObj.Content = Display3d(filename);
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
        
        private void transform()
        {
            startPos = new Point3D(xMaxi / 2, yMaxi / 2, zLow);
            Transform3DGroup trans3dgroup = new Transform3DGroup();
            TranslateTransform3D trans = new TranslateTransform3D(startPos.X - centerPoint.X + xOffset, startPos.Y - centerPoint.Y + yOffset, startPos.Z - centerPoint.Z + zOffset);
            currentPosition = startPos;
            currentPosition.X += xOffset;
            currentPosition.Y += yOffset;
            currentPosition.Z += zOffset;
            ScaleTransform3D scale = new ScaleTransform3D(scaleX, scaleY, scaleZ, currentPosition.X, currentPosition.Y, currentPosition.Z);
            RotateTransform3D rotX = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(-1, 0, 0), degreeX), currentPosition);
            RotateTransform3D rotY = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, -1, 0), degreeY), currentPosition);
            RotateTransform3D rotZ = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 0, -1), degreeZ), currentPosition);
            trans3dgroup.Children.Add(trans);
            trans3dgroup.Children.Add(rotX);
            trans3dgroup.Children.Add(rotY);
            trans3dgroup.Children.Add(rotZ);
            trans3dgroup.Children.Add(scale);
            obj.Transform = trans3dgroup;

       }


        private void scaleDown()
        {
            scaleX -= 0.05;
            scaleY -= 0.05;
            scaleZ -= 0.05;
            Transform3DGroup trans3dgroup = new Transform3DGroup();
            TranslateTransform3D trans = new TranslateTransform3D(currentPosition.X - centerPoint.X, currentPosition.Y - centerPoint.Y, zLow);
            ScaleTransform3D scale = new ScaleTransform3D(scaleX, scaleY, scaleZ, currentPosition.X, currentPosition.Y, zLow);
            trans3dgroup.Children.Add(trans);
            trans3dgroup.Children.Add(scale);
            if (isInBounds(trans3dgroup))
            {
                obj.Transform = trans3dgroup;
            }
            else
            {
                scaleDown();
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
            Point3D yPoint = new Point3D(0, yMaxi, 0);
            Point3D xPoint = new Point3D(xMaxi, 0, 0);
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
            for (int i = 20; i <= xMaxi; i += 20)
            {
                LinesVisual3D xLine1 = new LinesVisual3D();
                LinesVisual3D yLine1 = new LinesVisual3D();

                Point3D xPoint30 = new Point3D(i, 0, 0);
                Point3D xPoint31 = new Point3D(i, xMaxi, 0);
                xLine1.Points.Add(xPoint30);
                xLine1.Points.Add(xPoint31);
                xLine1.Color = Colors.Black;

                Point3D yPoint30 = new Point3D(0, i, 0);
                Point3D yPoint31 = new Point3D(xMaxi, i, 0);
                yLine1.Points.Add(yPoint30);
                yLine1.Points.Add(yPoint31);
                yLine1.Color = Colors.Black;

                viewPort3d.Children.Add(xLine1);
                viewPort3d.Children.Add(yLine1);

            }
        }


        private Point3D getCenter()
        {
            Model3D device2 = obj.Content;
            var bounds = device2.Bounds;
            var x = bounds.X + (bounds.SizeX / 2);
            var y = bounds.Y + (bounds.SizeY / 2);
            var z = bounds.Z + (bounds.SizeZ / 2);
            Point3D result = new Point3D(x, y, 0);
            return result;
        }

        private void writeDataHandle(object sender, RoutedEventArgs e)
        {
            writeData();   
        }
        public async Task writeData()
        {
            //If the object is not within the bounds of the table, generate error message
            if(!isInBounds(obj.Transform))
            {
                double zMin = getLowestZ();
                MessageBox.Show("Warning: Object not within table boundaries. Consider moving or resizing the object and try again. (zMin value is "+zMin.ToString()+")");
                return;
            }
            MeshGeometry3D mesh = (MeshGeometry3D)((GeometryModel3D)model.Children[0]).Geometry;
            Point3D[] _3dPoints = mesh.Positions.ToArray();
            Vector3D[] normVectors = mesh.Normals.ToArray();
            Point3D tempPoint;
            Vector3D tempVec;
            double zHeight = 0;
            StreamWriter file = new StreamWriter("ModelData.txt");
            for (int i = 0; i < _3dPoints.Length; i++)
            {
                tempPoint = obj.Transform.Transform(_3dPoints[i]);
                tempVec = obj.Transform.Transform(normVectors[i]);
                await file.WriteLineAsync(tempPoint.X + " " + tempPoint.Y + " " + tempPoint.Z);
                if ((i + 1) % 3 == 0)
                {
                    await file.WriteLineAsync("V: " + tempVec.X + " " + tempVec.Y + " " + tempVec.Z);
                }
                if (tempPoint.Z > zHeight)
                {
                    zHeight = tempPoint.Z;
                }
            }
            await file.WriteLineAsync(zHeight.ToString());
            file.Close();
        }

        private Boolean isInBounds(Transform3D trans)
        {
            Point3D[] points = obj.MeshGeometry.Positions.ToArray();
            trans.Transform(points);
            double xMin = points[0].X;
            double xMax = points[0].X;
            double yMin = points[0].Y;
            double yMax = points[0].Y;
            double zMax = points[0].Z;
            double zMin = points[0].Z;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i].X < xMin)
                {
                    xMin = points[i].X;
                }
                if (points[i].X > xMax)
                {
                    xMax = points[i].X;
                }
                if (points[i].Y < yMin)
                {
                    yMin = points[i].Y;
                }
                if (points[i].Y > yMax)
                {
                    yMax = points[i].Y;
                }
                if (points[i].Z < zMin)
                {
                    zMin = points[i].Z;
                }
                if (points[i].Z > zMax)
                {
                    zMax = points[i].Z;
                }
            }
            if ((xMin >= 0) && (xMax <= xMaxi) && (yMin >= 0) && (yMax <= yMaxi) && (zMin >= 0) && (zMax <= 200))
            {
                return true;
            }
            return false;
        }

        private double getZLow()
        {
            Point3D[] points = obj.MeshGeometry.Positions.ToArray();
            zLow = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].Z < zLow)
                {
                    zLow = points[i].Z;
                }
            }
            zLow = -zLow;
            return zLow;
        }

        private void set()
        {
            startPos = new Point3D(xMaxi/2, yMaxi/2, zLow);
            TranslateTransform3D trans = new TranslateTransform3D(startPos.X - currentPosition.X, startPos.Y - currentPosition.Y, startPos.Z);
            obj.Transform = trans;
            currentPosition = startPos;
        }


        private void reset(object sender, RoutedEventArgs e)
        {
            startPos = new Point3D(xMaxi / 2, yMaxi / 2, zLow);
            TranslateTransform3D trans = new TranslateTransform3D(startPos.X - centerPoint.X, startPos.Y - centerPoint.Y, zLow);
            obj.Transform = trans;
            currentPosition = startPos;
            xOffset = 0;
            yOffset = 0;
            zOffset = 0;
            degreeX = 0;
            degreeY = 0;
            degreeZ = 0;
            scaleX = 1;
            scaleY = 1;
            scaleZ = 1;
            scaleDown();
        }

        private void downToTable(object sender, RoutedEventArgs e)
        {
            Transform3DGroup trans3Dgroup = new Transform3DGroup();
            double zMin = getLowestZ();
            ScaleTransform3D scale = new ScaleTransform3D(scaleX, scaleY, scaleZ, currentPosition.X, currentPosition.Y, currentPosition.Z - zMin);
            TranslateTransform3D trans = new TranslateTransform3D(currentPosition.X - centerPoint.X, currentPosition.Y - centerPoint.Y, currentPosition.Z - zMin);
            zOffset = currentPosition.Z - zMin;
            currentPosition.Z -= zMin;
            RotateTransform3D rotX = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(-1, 0, 0), degreeX), currentPosition);
            RotateTransform3D rotY = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, -1, 0), degreeY), currentPosition);
            RotateTransform3D rotZ = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 0, -1), degreeZ), currentPosition);
            trans3Dgroup.Children.Add(trans);
            trans3Dgroup.Children.Add(rotX);
            trans3Dgroup.Children.Add(rotY);
            trans3Dgroup.Children.Add(rotZ);
            trans3Dgroup.Children.Add(scale);
            obj.Transform = trans3Dgroup;
            
        }

        private double getLowestZ()
        {
            double zMin = zMaxi;
            Point3D[] points = obj.MeshGeometry.Positions.ToArray();
            obj.Transform.Transform(points);
            for(int i = 0; i < points.Length;i++)
            {
                if(points[i].Z < zMin)
                {
                    zMin = points[i].Z;
                }
            }
            return zMin;
        }

        private void showScale(object sender, RoutedEventArgs e)
        {
            xScaleInput.Text = scaleX.ToString();
            yScaleInput.Text = scaleY.ToString();
            zScaleInput.Text = scaleZ.ToString();
        }

        private void showTrans(object sender, RoutedEventArgs e)
        {
            xOffsetInput.Text = xOffset.ToString();
            yOffsetInput.Text = yOffset.ToString();
            zOffsetInput.Text = zOffset.ToString();

        }

        private void showRot(object sender, RoutedEventArgs e)
        {
            xRotInput.Text = degreeX.ToString();
            yRotInput.Text = degreeY.ToString();
            zRotInput.Text = degreeZ.ToString();
        }

        private void setTrans(object sender, RoutedEventArgs e)
        {
            try
            {
                xOffset = Convert.ToDouble(xOffsetInput.Text);
                yOffset = Convert.ToDouble(yOffsetInput.Text);
                zOffset = Convert.ToDouble(zOffsetInput.Text);
                transform();
            }
            catch
            {              
            }  
            
        }

        private void setRot(object sender, RoutedEventArgs e)
        {
            try
            {
                degreeX = Convert.ToInt32(xRotInput.Text);
                degreeY = Convert.ToInt32(yRotInput.Text);
                degreeZ = Convert.ToInt32(zRotInput.Text);
                transform();
            }
            catch
            {
            }
        }

        private void setScale(object sender, RoutedEventArgs e)
        {
            try
            {
                scaleX = Convert.ToDouble(xScaleInput.Text);
                scaleY = Convert.ToDouble(yScaleInput.Text);
                scaleZ = Convert.ToDouble(zScaleInput.Text);
                transform();
            }
            catch
            {
            }
        }
    }
}