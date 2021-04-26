#include <iostream>
#include <string>

using namespace Slicing_Data_Structure
{
    class vector
    {
        public:
         vector(double x, double y)
        {
            super();
            this.x = x;
            this.y = y;
            
            /*Represents a 2D vector with:
              x coordinate
              y coordinate
              A 2D vector is being used in this case because we intend......
              .......to make the layer into multiple connected graphs */
        }

        public:
         double dotProduct(vector d)
        {
            
            return this.x * d.x + this.y * d.y; 
            /* The formula calculates the scalar product 
                and returns scalar product*/
        }

        public:
         vector length()
        {
            return double Math.sqrt(Math.pow(x,2) + Math.pow(y,2));
            /* The formula is used to find the length of the 2D vector*/
        }

        public:
         boolean isNull()
        {
            if(this.x == 0 && this.y == 0)
            {
                return true;
            }

            return false;
            /* Used to check if it is a null vector */
        }

        public:
         vector addition(vector p)
        {
            return new vector(this.x + p.x, this.y + p.y);
            /* Adds two vectors*/
        }

        public:
         vector division(vector p)
        {
            return new vector(this.x/p.x, this.y/p.y);
            /* Divides the former vector by the latter*/ 
        }

        public:
         vector multiplication(vector p)
        {
            return new vector(this.x * p.x, this.y * p.y);
            /* Multiplies two vectors*/
        }

        public:
         vector subtraction(vector p)
        {
            return new vector(this.x - p.x, this.y - p.y);
            /* Subtracts one vector from the other*/
        }

    }
}
