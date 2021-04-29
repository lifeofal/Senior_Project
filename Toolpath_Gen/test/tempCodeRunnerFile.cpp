rator g1("../settings/config.ini");

    g1.open_File();
    while(!m.empty())
    {
        g1.print_XYE(m.front());
        m.pop();
    }