using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Slicing_Data_Structure
{
    public partial class vector
    {
        public vector(double x, double y, double z)
        {
            super();
            this.x = x;
            this.y = y;
            this.z = z;
            /*Represents a 3D vector with:
              x coordinate
              y coordinate
              z coordinate */
        }

        public double dotProduct(vector d)
        {
            
            return this.x * d.x + this.y * d.y + this.z * d.z; 
            /* The formula calculates the scalar product 
                and returns sclar product*/
        }

        public vector length()
        {
            return double Math.sqrt(Math.pow(x,2) + Math.pow(y,2) + Math.pow(z,2));
            /* The formula is used to find the length of the vector*/
        }

        public boolean isNull()
        {
            if(thisx == 0 && this.y == 0 && this.z == 0)
            {
                return true;
            }

            return false;
            /* Used to check if it is a null vector */
        }

        public vector addition(vector p)
        {
            return new vector(this.x + p.x, this.y + p.y, this.z + p.z);
            /* Adds two vectors*/
        }

        public vector division(vector p)
        {
            return new vector(this.x/p.x, this.y/p.y, this.z/p.z);
            /* Divides the former vector by the latter*/ 
        }

        public vector multiplication(vector p)
        {
            return new vector(this.x * p.x, this.y * p.y, this.z * p.z);
            /* Multiplies two vectors*/
        }

        public vector subtraction(vector p)
        {
            return new vector(this.x - p.x, this.y - p.y, this.z - p.z);
            /* Subtracts one vector from the other*/
        }

    }
}
