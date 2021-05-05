#include "../lib/toolpath_gen.cpp"
#include "../lib/mesh.cpp"


int main()
{
    Triangle adder;
    adder.insertXYZ(0.0,0.0,0.0,0.0,1.0,0.0,0.0,1.0,1.0);
    adder.insertNormXYZ(0.0,1.0,1.0);
    // Lines my_lines;
    // my_lines.insertline(0.0000001,0.0000001, 0.0000001,1.0000001);
    // my_lines.insertline(3.0000001,3.0000001, 3.0000001,5.0000001);
    // my_lines.insertline(5.0000001,3.0000001, 3.0000001,5.0000001);
    // my_lines.insertline(1.0000001,0.0000001, 0.0000001,1.0000001);
    // my_lines.insertline(0.0000001,0.0000001, 1.0000001,0.0000001);
    // my_lines.insertline(3.0000001,3.0000001, 5.0000001,3.0000001);

    // my_lines.showV();
    // std::cout<<std::endl;

    // Layer my_layer;

    // my_layer = my_lines.sort();

    // while(!my_layer.isEmpty())
    // {
    //     std::cout<<"New Perimeter\n";
    //     my_layer.get_Perimeter().showV();
    //     my_layer.drop();
    // }

}