#include "lines.h"
#include <iostream>

using namespace std;

Lines::Lines()
{

}

Lines Lines::copy()
{

}

void Lines::insertline(float x1, float y1, float x2, float y2)
{
    line temp;
    dot xy1;
    dot xy2;
    xy1.x = x1;
    xy1.y = y1;
    xy2.x = x2;
    xy2.y = y2;
    temp.xy1 = xy1;
    temp.xy2 = xy2;
    
    data.push_back(temp);
}

void Lines::insert(line n)
{
    data.push_back(n);
}

    // Big sorting algorithm
Layer Lines::sort()
{
    Layer output;
    //choose a random point in the vector to start (easiest is the first point in the vector) and push that line to a perimeter
    
	// std::cout<<"Got to start of sort"<<endl;
    while(!isEmpty())   // While the vector is not empty
    {
	    // std::cout<<"Got to start of isEmpty"<<endl;
        Perimeter p1;   // initialize temporary Permimeter
        p1.insert(data[0].xy1); // Set first value of Perimeter to first xy of line vector
        p1.insert(data[0].xy2); // Set second value of Perimeter to second xy of line vector
        data.erase(data.begin());   // Erase first line of line vector
        while(p1.get_front() != p1.back()) // while the front of Perimeter doesn't match the back, AKA while the Perimeter is not a loop
        {
            cout<<"Perimeter F&B:\t"<<p1.get_front().x<<", "<<p1.get_front().y<<"\t"<<p1.back().x<<","<<p1.back().y<<endl;
            vector<line>::iterator itr = data.begin();
            while(itr != data.end())
            {
                // cout<<"\nIterator: "<<itr->print();
                showV();
                cout <<"itr val: "<<itr->print();
                cout <<"itr == xy: "<< (p1.back() == itr->xy1 || p1.back() == itr->xy2)<<endl;
                if(p1.back() == itr->xy1)
                {
                    p1.insert(itr->xy2);
                    data.erase(itr);
                    break;
                }
                else if(p1.back() == itr->xy2)
                {
                    p1.insert(itr->xy1);
                    data.erase(itr);
                    break;
                }
                ++itr;
            }

        }
        output.insert(p1);
    }

    return output;
}

bool Lines::isEmpty()
{
    return data.empty();
}

void Lines::showV()
{
    cout<<"\nShowV: \n";
    for(vector<line>::iterator line_iterator = data.begin(); line_iterator != data.end(); ++line_iterator)
    {
        cout << line_iterator->print();
    } 
}


void Lines::insertV(vector<line> v)
{

}
