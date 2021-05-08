//#include "../lib/toolpath_gen.cpp"
#include "../ToolpathGen/ToolpathGen.cpp"


int main()
{
    char* outPath;
    outPath = "F:/repos/lifeofal/Senior_Project/ToolpathGen/resource";
    std::cout << outPath;
    main_slice(outPath);
    // Mesh tester_M;
    // Triangle tester_T;
    // Point tester_P;
    // tester_T.insertXYZ(1.0,1.0,1.0,0.0,1.0,0.0,0.0,1.0,1.0);
    // tester_T.insertNormXYZ(0.0,1.0,1.0);
    // // cout << "Current Max Z is: " << tester_T.maxZHeight() << "expecting 1" << endl;
    // tester_M.insertTriangle(tester_T);

    // tester_T.insertXYZ(0.0,0.0,0.0,0.0,1.0,0.0,0.0,1.0,0.0);
    // tester_T.insertNormXYZ(0.0,1.0,1.0);
    // // cout << "Current Max Z is: " << tester_T.maxZHeight() << "expecting 0" << endl;
    // tester_M.insertTriangle(tester_T);

    // tester_T.insertXYZ(0.0,0.0,2.0,0.0,1.0,0.0,0.0,1.0,1.0);
    // tester_T.insertNormXYZ(0.0,1.0,1.0);
    // // cout << "Current Max Z is: " << tester_T.maxZHeight() << "expecting 2" << endl;
    // tester_M.insertTriangle(tester_T);

    // tester_T.insertXYZ(0.0,0.0,0.0,1.0,1.0,0.0,0.0,1.0,1.0);
    // tester_T.insertNormXYZ(0.0,1.0,1.0);
    // // cout << "Current Max Z is: " << tester_T.maxZHeight() << "expecting 1" << endl;
    // tester_M.insertTriangle(tester_T);

    // tester_M.printMesh();

    // tester_M.getTrig(0).printTriangle();
    // tester_M.getTrig(2).printTriangle();


    // tester_M.trim(1.5);

    // cout << "test" << endl;
    // tester_M.getTrig().printTriangle();







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
    //     std::cout<<"New Perimeter/n";
    //     my_layer.get_Perimeter().showV();
    //     my_layer.drop();
    // }

}